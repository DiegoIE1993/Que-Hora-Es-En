namespace QueHoraEsEn
{
    public partial class Form1 : Form
    {
        private ZonaHorariaService _horariaService;
        public Form1()
        {
            InitializeComponent();
            _horariaService = new ZonaHorariaService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraLocal.Text = DateTime.Now.ToString("HH:mm");
            lblSegundos1.Text = DateTime.Now.ToString("ss");
            lblFecha1.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDia1.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var fechaLocal = _horariaService.GetFechaActualPorZonaHoraria("Eastern Standard Time");
            

            lblHoraZona2.Text = fechaLocal.ToString("HH:mm");
            lblSegundos2.Text = fechaLocal.ToString("ss");
            lblFecha2.Text = fechaLocal.ToString("MMM dd yyyy");
            lblDia2.Text = fechaLocal.ToString("dddd");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var fechaLocal = _horariaService.GetFechaActualPorZonaHoraria("China Standard Time");
            

            lblSegundos3.Text = fechaLocal.ToString("ss");
            lblHoraZona3.Text = fechaLocal.ToString("HH:mm");
            lblFecha3.Text = fechaLocal.ToString("MMM dd yyyy");
            lblDia3.Text = fechaLocal.ToString("dddd");

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var fechaLocal = _horariaService.GetFechaActualPorZonaHoraria("Tokyo Standard Time");
            

            lblHoraZona4.Text = fechaLocal.ToString("HH:mm");
            lblSegundos4.Text = fechaLocal.ToString("ss");
            lblFecha4.Text = fechaLocal.ToString("MMM dd yyyy");
            lblDia4.Text = fechaLocal.ToString("dddd");
        }


    }
}
