using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnSumarClicked (object sender, EventArgs e)
	{
		int Num1= int.Parse(this.numero1.Text);
		int Num2 = int.Parse(this.numero2.Text);
		int operacion=(Num1 + Num2);

		this.resultado.Text = operacion.ToString();
	}

	protected void OnBtnRestarClicked (object sender, EventArgs e)
	{
		int Num1= int.Parse(this.numero1.Text);
		int Num2 = int.Parse(this.numero2.Text);
		int operacion=(Num1 - Num2);
		
		this.resultado.Text = operacion.ToString();
	}

	protected void OnBtnMultiplicarClicked (object sender, EventArgs e)
	{
		int Num1= int.Parse(this.numero1.Text);
		int Num2 = int.Parse(this.numero2.Text);
		int operacion=(Num1 * Num2);
		
		this.resultado.Text = operacion.ToString();
	}

	protected void OnBtnDividirClicked (object sender, EventArgs e)
	{
		int Num1= int.Parse(this.numero1.Text);
		int Num2 = int.Parse(this.numero2.Text);
		int operacion=(Num1 / Num2);
		
		this.resultado.Text = operacion.ToString();
	}

	protected void OnBtnLimpiarClicked (object sender, EventArgs e)
	{
		this.numero1.Text="";
		this.numero2.Text="";
		this.resultado.Text="";
	}
}
