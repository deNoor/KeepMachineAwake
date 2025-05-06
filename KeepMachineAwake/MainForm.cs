using Vanara.PInvoke;

namespace KeepMachineAwake;

public sealed partial class MainForm : Form
{
    private readonly AppState _appState;

    public MainForm()
    {
        InitializeComponent();
        _appState = new();
    }

    private void TrayIconCmExit_Click(object sender, EventArgs e) => Close();

    private void MainForm_Load(object sender, EventArgs e)
    {
        Hide();
        _appState.SetActive(this, true);
    }

    private class AppState
    {
        private readonly Dictionary<bool, Icon> _trayIcons = new()
        {
            [true] = new(new MemoryStream(Properties.Resources.eyes_open)),
            [false] = new(new MemoryStream(Properties.Resources.eyes_closed)),
        };

        private bool Active { get; set; }

        public void SetActive(MainForm mainForm, bool state)
        {
            Active = state;
            mainForm.TrayIcon.Icon = _trayIcons[Active];
            mainForm.TrayIconActive.Checked = Active;
            var threadState = Kernel32.EXECUTION_STATE.ES_CONTINUOUS;
            if (Active)
            {
                threadState |= Kernel32.EXECUTION_STATE.ES_SYSTEM_REQUIRED | Kernel32.EXECUTION_STATE.ES_DISPLAY_REQUIRED;
            }
            Kernel32.SetThreadExecutionState(threadState);
        }

        public void Switch(MainForm mainForm) => SetActive(mainForm, !Active);
    }

    private void TrayIconActive_Click(object sender, EventArgs e) => _appState.Switch(this);

    private void TrayIcon_DoubleClick(object sender, EventArgs e)
    {
        var mouseEventArgs = (MouseEventArgs) e;
        if (mouseEventArgs.Button != MouseButtons.Left)
        {
            return;
        }
        _appState.Switch(this);
    }
}
