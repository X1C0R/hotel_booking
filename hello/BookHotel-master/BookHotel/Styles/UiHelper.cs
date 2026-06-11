using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class UiHelper
{
    // For any control (Panel, UserControl, etc.)
    public static void MakeRounded(Control control, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
        path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
        path.CloseFigure();
        control.Region = new Region(path);
    }

    public static void CreateBottomBorderTextBox(Panel parent, string placeholder, int top, int width)
    {
        // 1. The Wrapper Panel (serves as the container)
        var wrapper = new Panel
        {
            Location = new Point(30, top),
            Size = new Size(width, 30),
            BackColor = Color.Transparent
        };

        // 2. The TextBox
        var txt = new TextBox
        {
            Text = placeholder,
            ForeColor = Color.Gray, // Placeholder color
            BorderStyle = BorderStyle.None,
            Location = new Point(0, 0),
            Size = new Size(width, 25),
            Font = new Font("Segoe UI", 11)
        };

        // 3. Bottom Border Logic (Paint event)
        wrapper.Paint += (s, e) =>
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(200, 200, 200), 2), 0, wrapper.Height - 1, wrapper.Width, wrapper.Height - 1);
        };

        // 4. Placeholder Logic
        txt.GotFocus += (s, e) =>
        {
            if (txt.Text == placeholder)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        };

        txt.LostFocus += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Gray;
            }
        };

        wrapper.Controls.Add(txt);
        parent.Controls.Add(wrapper);
    }
    //for the button
    public static void RoundButton(Button button, int radius)
    {
        Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);

        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;

        path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
        path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
        path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        button.Region = new Region(path);

        // optional: smoother look
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
    }
}