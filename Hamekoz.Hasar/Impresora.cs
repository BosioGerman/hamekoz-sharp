//
//  Impresora.cs
//
//  Author:
//       Ezequiel Taranto <ezequiel89@gmail.com>
//
//  Copyright (c) 2014 etaranto
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Hamekoz.Hasar
{
	public class Impresora
	{
		public string printerIP { get; set; }

		public int printerPort { get; set; }

		public string comando { get; set; }
		//private char separador { get; set; }
		private EndPoint ep { get; set; }

		private Socket sock { get; set; }

		private NetworkStream ns { get; set; }

		public void Conectar (string printerIP, int printerPort)
		{
			ep = new IPEndPoint (IPAddress.Parse (printerIP), printerPort);
			sock = new Socket (ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			try {
				sock.Connect (ep);
			} catch (Exception e) {
				Console.WriteLine (e.ToString ());
				throw (new Exception ("No se pudo conectar con la impresora"));
			}

		}

		public void Desconectar ()
		{
			try {
				sock.Shutdown (SocketShutdown.Both);
				sock.Close ();
			} catch (Exception e) {
				Console.WriteLine (e.ToString ());
			}
		}

		public void EnviarComando (string comando)
		{
			try {
				//sock.SendTimeout = 3000;
				//sock.ReceiveTimeout = 3000;
				//For iso-8859-1, use Encoding.GetEncoding("iso-8859-1");
				// For ASCII  CP437, use Encoding.GetEncoding(437)
				Encoding enc = Encoding.GetEncoding (437);//*********
				ns = new NetworkStream (sock);
				Console.WriteLine ("Debug: Comando: " + comando);
				//byte[] toSend = Encoding.ASCII.GetBytes(comando);
				byte[] toSend = enc.GetBytes (comando);//**********
				ns.BeginWrite (toSend, 0, toSend.Length, OnWriteComplete, null);
				ns.Flush ();
			} catch (Exception e) {
				Console.WriteLine (e.ToString ());
			}
		}

		public string[] LeerRespuesta ()
		{
			// Examples for CanRead, Read, and DataAvailable.
			// Check to see if this NetworkStream is readable.
			//myCompleteMessage = string.Empty;
			StringBuilder myCompleteMessage = new StringBuilder ();
			while (ns.CanRead) {
				byte[] myReadBuffer = new byte[1024];
				myCompleteMessage = new StringBuilder ();
				int numberOfBytesRead = 0;
				// Incoming message may be larger than the buffer size.
				do {
					numberOfBytesRead = ns.Read (myReadBuffer, 0, myReadBuffer.Length);
					myCompleteMessage.AppendFormat ("{0}", Encoding.ASCII.GetString (myReadBuffer, 0, numberOfBytesRead));
				} while(ns.DataAvailable);
				// Print out the received message to the console.
				Console.WriteLine ("Debug: Respuesta Impresora -> {0}", myCompleteMessage);
				if (myCompleteMessage.ToString () != "DC2" && myCompleteMessage.ToString () != "DC4" && myCompleteMessage.ToString () != string.Empty) {
					break;
				}
			}
			return myCompleteMessage.ToString ().Split ((char)28);
		}

		private void OnWriteComplete (IAsyncResult ar)
		{
			NetworkStream thisNS = ns;
			thisNS.EndWrite (ar);
		}


	}
}
