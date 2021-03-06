﻿//
//  ItemChooser.cs
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
using Xwt;
using System;

namespace Hamekoz.UI
{
	public class ItemChooser<T> : HPaned
	{
		public event ListBoxFilterSelectionChanged SelectedItemChanged;

		readonly ListBoxFilter<T> list = new ListBoxFilter<T> {
			RealTimeFilter = true,
			WidthRequest = 200,
			MarginRight = 5,
			LableVisible = false,
		};

		public ListBoxFilter<T> List {
			get { return list; }
		}

		readonly VBox container = new VBox {
			ExpandVertical = true,
			ExpandHorizontal = false,
			VerticalPlacement = WidgetPlacement.Fill,
			MarginLeft = 5,
			WidthRequest = 300,
		};

		public Widget Widget {
			get { return scroller.Content; }
			set { scroller.Content = value; }
		}

		readonly HBox actionBox = new HBox {
			ExpandHorizontal = true,
			ExpandVertical = true,
			HorizontalPlacement = WidgetPlacement.Fill,
			VerticalPlacement = WidgetPlacement.Fill,
		};

		readonly ScrollView scroller = new ScrollView {
			BorderVisible = false,
			VerticalScrollPolicy = ScrollPolicy.Automatic,
			HorizontalScrollPolicy = ScrollPolicy.Automatic,
		};

		public ItemChooser ()
		{
			list.SelectionItemChanged += ListSelectionChanged;
			container.PackStart (scroller, true, true);
			container.PackEnd (actionBox, false, true);
			Panel1.Content = list;
			Panel1.Shrink = false;
			Panel1.Resize = true;
			Panel2.Content = container;
			Panel2.Shrink = false;
			Panel2.Resize = true;
		}

		void ListSelectionChanged (object sender, EventArgs e)
		{
			var handler = SelectedItemChanged;
			if (handler != null)
				handler (this, e);
		}

		public void AddAction (Button action)
		{
			actionBox.PackStart (action, true, true);
		}
	}
}