using System.Drawing;
using System.Windows.Forms;

namespace v2rayP.UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            this.Icon = Icon.FromHandle(Properties.Resources.v2ray_128x128.GetHicon());
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
    }
}
