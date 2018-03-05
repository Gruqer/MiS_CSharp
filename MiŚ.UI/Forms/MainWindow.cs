using System.Windows.Forms;
using MiŚ.Core.User;

namespace MiŚ.UI.Forms
{
    public partial class MainWindow : Form
    {
        private User user;

        public MainWindow(User user)
        {
            this.user = user;
            InitializeComponent();
        }
    }
}
