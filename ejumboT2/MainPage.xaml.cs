namespace ejumboT2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCalcularNotaFinalClicked(object sender, EventArgs e)
    {
        // Obtener las notas ingresadas
        double seguimiento1 = double.Parse(Seguimiento1Entry.Text);
        double examen1 = double.Parse(Examen1Entry.Text);
        double seguimiento2 = double.Parse(Seguimiento2Entry.Text);
        double examen2 = double.Parse(Examen2Entry.Text);

        // Calcular notas parciales
        double notaParcial1 = (seguimiento1 * 0.3) + (examen1 * 0.2);
        double notaParcial2 = (seguimiento2 * 0.3) + (examen2 * 0.2);

        // Calcular nota final
        double notaFinal = notaParcial1 + notaParcial2;

        // Determinar estado
        string estado;
        if (notaFinal >= 7)
            estado = "Aprobado";
        else if (notaFinal >= 5)
            estado = "Complementario";
        else
            estado = "REPROBADO";

        // Mostrar resultados en un DisplayAlert
        string mensaje = $"Nombre: {NombreEntry.Text}\n" +
                         $"Fecha: {FechaPicker.Date.ToString("dd/MM/yyyy")}\n" +
                         $"Nota Parcial 1: {notaParcial1:F2}\n" +
                         $"Nota Parcial 2: {notaParcial2:F2}\n" +
                         $"Nota Final: {notaFinal:F2}\n" +
                         $"Estado: {estado}";

        DisplayAlert("Resultados", mensaje, "OK");
    }
}


