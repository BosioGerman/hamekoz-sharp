
// This file has been generated by the GUI designer. Do not modify.
namespace Hamekoz.UI.Gtk
{
	public partial class DialogTreeView
	{
		private global::Hamekoz.UI.Gtk.SearchableTreeView searchabletreeview;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Hamekoz.UI.Gtk.DialogTreeView
			this.Name = "Hamekoz.UI.Gtk.DialogTreeView";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.Decorated = false;
			// Internal child Hamekoz.UI.Gtk.DialogTreeView.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.searchabletreeview = new global::Hamekoz.UI.Gtk.SearchableTreeView ();
			this.searchabletreeview.WidthRequest = 220;
			this.searchabletreeview.HeightRequest = 180;
			this.searchabletreeview.Events = ((global::Gdk.EventMask)(256));
			this.searchabletreeview.Name = "searchabletreeview";
			this.searchabletreeview.ActualId = 0;
			w1.Add (this.searchabletreeview);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.searchabletreeview]));
			w2.Position = 0;
			// Internal child Hamekoz.UI.Gtk.DialogTreeView.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonCancel]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonOk]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 228;
			this.DefaultHeight = 230;
			w3.Hide ();
			this.Show ();
		}
	}
}
