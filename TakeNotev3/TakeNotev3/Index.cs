using TakeNotev3.UserControls;

namespace TakeNotev3
{
    public partial class TakeNote : Form
    {
        NavigationControl navigationControl;

        public TakeNote()
        {
            InitializeComponent();
            InitializeNavigationControl();

        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {new NotesPage(), new GroupsPage(), new TaskPage()};

            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(0);
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);

        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

    }
}