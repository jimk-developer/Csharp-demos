using Guide12Examples.Examples;

namespace Guide12Examples.Models;

/// <summary>
/// The list of examples, in the same order as the sections in Guide 12.
/// Add a new example here and the launcher picks it up automatically.
/// </summary>
public static class ExampleCatalog
{
    public static IReadOnlyList<ExampleInfo> All { get; } =
    [
        new ExampleInfo(1, "Control Fundamentals and IDE Code",
            "Control, Component, MarshalByRefObject, widgets, InitializeComponent(), default events",
            () => new Example01ControlFundamentalsForm()),

        new ExampleInfo(2, "Fonts",
            "Font constructors, FontStyle, serif vs. sans serif, accessible fonts",
            () => new Example02FontsForm()),

        new ExampleInfo(3, "Color",
            "BackColor, ForeColor, predefined and custom colors, contrast, color blindness",
            () => new Example03ColorForm()),

        new ExampleInfo(4, "Selection Controls",
            "CheckBox, RadioButton, ButtonBase, Checked, CheckedChanged, access keys",
            () => new Example04SelectionControlsForm()),

        new ExampleInfo(5, "Grouping Controls",
            "GroupBox vs. Panel, independent radio button groups, scrolling",
            () => new Example05GroupingForm()),

        new ExampleInfo(6, "Graphics",
            "PictureBox, Image property, SizeMode, image file types",
            () => new Example06GraphicsForm()),

        new ExampleInfo(7, "List Controls",
            "ListBox, ComboBox, CheckedListBox, SelectionMode, MultiColumn, GetSelected()",
            () => new Example07ListControlsForm()),

        new ExampleInfo(8, "Date/Time Controls",
            "MonthCalendar, DateTimePicker, SelectionStart/End, MaxDate, AddDays()",
            () => new Example08DateTimeForm()),

        new ExampleInfo(9, "Multiple Forms and Navigation",
            "LinkLabel, LinkClicked, Show() vs. ShowDialog(), modal windows",
            () => new Example09MultipleFormsForm()),

        new ExampleInfo(10, "Form Layout",
            "Snap lines, Location, Anchor, Dock, ContainsFocus, Capture",
            () => new Example10LayoutForm()),

        new ExampleInfo(11, "Menus",
            "MenuStrip, access keys, Click() handlers, conventional menu order",
            () => new Example11MenusForm()),
    ];
}
