﻿//
//  Extensions.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2015 Hamekoz - www.hamekoz.com.ar
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
using Hamekoz.Core;
using Xwt;

namespace Hamekoz.UI
{
	public static class Extensions
	{
		public static Box WithLabel (this Widget widget, string label, bool horizontal = false, bool expand = true, bool fill = true)
		{
			Box box;
			if (horizontal) {
				box = new HBox ();
			} else {
				box = new VBox ();
			}
			if (widget is DatePicker) {
				expand = false;
				fill = false;
			}
			box.ExpandVertical = expand;
			box.ExpandHorizontal = expand;
			box.PackStart (new Label (label));
			box.PackStart (widget, expand, fill);
			return box;
		}

		public static ScrollView WithScroll (this TextArea widget, ScrollPolicy vertical = ScrollPolicy.Automatic, ScrollPolicy horizontal = ScrollPolicy.Never)
		{
			return new ScrollView (widget) {
				VerticalScrollPolicy = vertical,
				HorizontalScrollPolicy = horizontal,
				MinHeight = widget.MinHeight,
				MinWidth = widget.MinWidth
			};
		}

		public static void CallBackEvents (this Widget widget, ICallBack callbackable)
		{
			if (callbackable != null) {
				callbackable.CallBack.Message += (title, message) => MessageDialog.ShowMessage (widget.ParentWindow, title, message);
				callbackable.CallBack.Warning += (title, message) => MessageDialog.ShowWarning (widget.ParentWindow, title, message);
				callbackable.CallBack.Error += (title, message) => MessageDialog.ShowError (widget.ParentWindow, title, message);
				callbackable.CallBack.Confirmation += (title, message) => MessageDialog.Confirm (widget.ParentWindow, title, message, Command.Yes);
			}
		}

		public static void CallBackEvents (this ICallBack callbackable, Widget widget)
		{
			if (callbackable != null) {
				callbackable.CallBack.Message += (title, message) => MessageDialog.ShowMessage (widget.ParentWindow, title, message);
				callbackable.CallBack.Warning += (title, message) => MessageDialog.ShowWarning (widget.ParentWindow, title, message);
				callbackable.CallBack.Error += (title, message) => MessageDialog.ShowError (widget.ParentWindow, title, message);
				callbackable.CallBack.Confirmation += (title, message) => MessageDialog.Confirm (widget.ParentWindow, title, message, Command.Yes);
			}
		}
	}
}

