﻿//
//  RegistroImportacionCitiCompras.cs
//
//  Author:
//       Mariano Ripa <ripamariano@gmail.com>
//
//  Copyright (c) 2016 Hamekoz
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

namespace Hamekoz.Argentina.Citi
{
	public class RegistroImportacionCitiCompras
	{
		public DateTime Fecha {
			get;
			set;
		}

		public string TipoComprobante {
			get;
			set;
		}

		public string PuntoVenta {
			get;
			set;
		}

		public string NroComprobante {
			get;
			set;
		}

		public string Despacho {
			get;
			set;
		}

		public string CodDocumento {
			get;
			set;
		}

		public string NroDocumento {
			get;
			set;
		}

		public string RazonSocial {
			get;
			set;
		}


		public string Total {
			get;
			set;
		}

		public string Neto {
			get;
			set;
		}

		public string Exento {
			get;
			set;
		}

		public string IVA {
			get;
			set;
		}

		public string PercepcionesACuentaIVA {
			get;
			set;
		}

		public string PercepcionesACuentaOtros {
			get;
			set;
		}

		public string PercepcionesIB {
			get;
			set;
		}

		public string PercepcionesMunicipales {
			get;
			set;
		}

		public string ImpuestosInternos {
			get;
			set;
		}

		public string CodigoMoneda {
			get;
			set;
		}


		public string TipoDeCambio {
			get;
			set;
		}

		public string CantidadAlicuotaIVA {
			get;
			set;
		}

		public string CodigoOperacion {
			get;
			set;
		}

		public string CreditoFiscal {
			get;
			set;
		}

		public string OtrosTributos {
			get;
			set;
		}

		public string CUITEmisor {
			get;
			set;
		}

		public string DenominacionEmisor {
			get;
			set;
		}

		public string IVAComision {
			get;
			set;
		}

		public string ToFixedString ()
		{

			string cadena = string.Format ("{0:yyyyMMdd}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}"
				, Fecha
				, TipoComprobante
				, PuntoVenta
				, NroComprobante
				, Despacho
				, CodDocumento
				, NroDocumento
				, RazonSocial
				, Total
				, Neto
				, IVA
				, PercepcionesACuentaIVA
				, PercepcionesACuentaOtros
				, PercepcionesIB
				, PercepcionesMunicipales
				, ImpuestosInternos
				, CodigoMoneda
				, TipoDeCambio
				, CantidadAlicuotaIVA
				, CodigoOperacion
				, CreditoFiscal
				, OtrosTributos
				, CUITEmisor
				, DenominacionEmisor
				, IVAComision

			                );
			if (cadena.Length != 51) {
				throw new Exception (string.Format ("La longitud del registro a exportar es incorrecta."));
			}

			return cadena;
		}

	}
}

