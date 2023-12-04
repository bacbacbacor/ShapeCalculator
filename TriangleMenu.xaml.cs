namespace ShapeCalculator;

public partial class TriangleMenu : TabbedPage
{

	
	public TriangleMenu()
	{
		InitializeComponent();
	}

	//public List<string> Units { get; } = new() {"in", "m", "cm", "km"};

	
	
	private void onClear1(object sender, EventArgs e)
	{
		txtedge1.Text = string.Empty;
		txtedge2.Text = string.Empty;
		result_A.Text = string.Empty;
    }

    private void onClear3(object sender, EventArgs e)
    {
        txtbase.Text = string.Empty;
		txtradius.Text = string.Empty;	
		txtheight.Text = string.Empty;
		result_VC.Text = string.Empty;
    }

    private void onClear2(object sender, EventArgs e)
    {
       

		txtSide1.Text = string.Empty;
		txtSide2.Text = string.Empty;
		txtSide3.Text = string.Empty;
		result_P.Text = string.Empty;
    }

    private void onClear4(object sender, EventArgs e)
    {
        txtside.Text = string.Empty;
		txtArea.Text = string.Empty;
		txtPero.Text = string.Empty;
		txtVC.Text = string.Empty;
        txtArea.Text = string.Empty;
        txtPero.Text = string.Empty;
        txtVC.Text =  string.Empty;
    }

	private void onClear5(object sender, EventArgs e)
	{
		txtreclen.Text = string.Empty;
		txtrecwid.Text = string.Empty;
		txtRecarea.Text = string.Empty;
		txtRecPeri.Text = string.Empty;
	}

	private void onClear6(object sender, EventArgs e)
	{
		txtreclen_1.Text = string.Empty;
		txtredwid_2.Text = string.Empty;
		txtRecheight.Text = string.Empty;
		txtResultVol.Text = string.Empty;
	}

	private void onClear7(object sender, EventArgs e)
	{ 
		txtcircRad.Text = string.Empty;
		txtcircArea.Text = string.Empty;
		txtcircCum.Text = string.Empty;
		txtcircVol.Text = string.Empty;		
	}



    //double.TryParse(edge1.Text, out double result);

    private void onClicked1(object sender, EventArgs e)
	{
		//double value1;
		double.TryParse(txtedge1.Text, out double value1);
        double.TryParse(txtedge2.Text, out double value2);
        double result = (0.5)*(value1)*(value2);
		result_A.Text = $"{result}{pkrTriUnit.SelectedItem}";
	}

	private void onCLicked2(object sender, EventArgs e)
	{
		double.TryParse(txtSide1.Text, out double value1);
        double.TryParse(txtSide2.Text, out double value2);
        double.TryParse(txtSide3.Text, out double value3);
		double result = value1 + value2 + value3;
		result_P.Text = $"{result}{pkrTriUnit2.SelectedItem}";
    }

	private void onClicked3(object sender, EventArgs e) 
	{
        double.TryParse(txtbase.Text, out double value1);
        double.TryParse(txtradius.Text, out double value2);
        double.TryParse(txtheight.Text, out double value3);

		double result = (Math.PI*Math.Pow(value2, 2)*value3)/3;
		result_VC.Text = $"{result}{pkrTriUnit3.SelectedItem}";
    }

    private void onClicked4(object sender, EventArgs e)
    {
		double.TryParse(txtside.Text, out double value1);

		double area = Math.Pow(value1, 2);
		double peri = 4 * value1;
		double volume = Math.Pow(value1, 3);

		txtArea.Text = $"{area}{pckSquaUnit.SelectedItem}";
		txtPero.Text = $"{peri}{pckSquaUnit.SelectedItem}";
		txtVC.Text = $"{volume}{pckSquaUnit.SelectedItem}";


	}


    private void onClicked5(object sender, EventArgs e)
	{
		double.TryParse(txtreclen.Text, out double value1);
        double.TryParse(txtrecwid.Text, out double value2);
		double resultArea = value1 * value2;
		double resultPeri = (2 * value1) + (2 * value2);

		txtRecarea.Text = $"{resultArea}{pckRecUnit.SelectedItem}";
        txtRecPeri.Text = $"{resultPeri}{pckRecUnit.SelectedItem}";

    }

    private void onClicked6(object sender, EventArgs e)
	{
		double.TryParse(txtreclen_1.Text, out double value1);
        double.TryParse(txtredwid_2.Text, out double value2);
        double.TryParse(txtRecheight.Text, out double value3);
		double resultVol = value1 * value2 * value3;
		txtResultVol.Text = $"{resultVol}{pckRecUnit2.SelectedItem}";

    }

    private void onClicked7(object sender, EventArgs e)
	{
		double.TryParse(txtcircRad.Text, out double value1);

		double area = Math.PI*Math.Pow(value1, 2);
		txtcircArea.Text = $"{area}{pckcircUnit.SelectedItem}";

		double cir = 2 * Math.PI * value1;
		txtcircCum.Text = $"{cir}{pckcircUnit.SelectedItem}";

		double vol = (4 / 3) * Math.PI * (Math.Pow(value1, 3));
		txtcircVol.Text = $"{vol}{pckcircUnit.SelectedItem}";
	}


}