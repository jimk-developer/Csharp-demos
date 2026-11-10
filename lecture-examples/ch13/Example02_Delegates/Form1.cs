// =====================================================================
//  EXAMPLE 2: Delegates and Composed Delegates
//
//  Key ideas:
//   - A DELEGATE is an object that holds a reference to a method.
//     (It is similar to a function pointer in C++.)
//   - A delegate can refer to ANY method with the same return type
//     and parameter list.
//   - Delegates can be COMBINED with + or += into a COMPOSED
//     delegate. Calling it calls each method, in order.
//   - -= removes a method from a delegate.
//   - = makes one delegate refer to the same method(s) as another.
//
//  Click the buttons in order, 1 through 5. Watch the list and LISTEN:
//  each method plays its own sound, so you can hear the order in
//  which a composed delegate calls its methods.
//      PlayChime()  -> chimes.wav
//      FlashLight() -> chord.wav
//      ShowPopup()  -> tada.wav
// =====================================================================

using System.Media;   // needed for SoundPlayer

namespace Example02_Delegates;

public partial class Form1 : Form
{
    // Declare a delegate TYPE with the delegate keyword.
    // An AlertHandler can refer to any method that
    // returns void and takes one string parameter.
    public delegate void AlertHandler(string message);

    // Three variables of the AlertHandler delegate type
    private AlertHandler chimeHandler;
    private AlertHandler flashHandler;
    private AlertHandler combinedHandler;

    public Form1()
    {
        InitializeComponent();

        // Each delegate gets a reference to one method.
        // Notice: no parentheses after the method name.
        chimeHandler = PlayChime;
        flashHandler = FlashLight;

        // A COMPOSED delegate: it refers to BOTH methods.
        combinedHandler = chimeHandler + flashHandler;
    }

    // ---------------------------------------------------------------
    //  Methods the delegates can refer to.
    //  All three match AlertHandler: void, one string parameter.
    // ---------------------------------------------------------------
    private void PlayChime(string message)
    {
        outputListBox.Items.Add("  Chime: " + message);
        outputListBox.Refresh();   // show the new line before the sound plays
        PlaySound("chimes.wav");
    }

    private void FlashLight(string message)
    {
        outputListBox.Items.Add("  Flash: " + message);
        outputListBox.Refresh();
        PlaySound("chord.wav");
    }

    // A STATIC method. A delegate for a static method holds only the
    // method itself, because no object is needed to call it.
    private static void ShowPopup(string message)
    {
        PlaySound("tada.wav");
        MessageBox.Show(message, "Popup");
    }

    // ---------------------------------------------------------------
    //  Helper: plays a .wav file from the Windows Media folder.
    //  PlaySync() waits until the sound finishes. That way, when a
    //  composed delegate calls two methods, you hear the sounds one
    //  after the other instead of the second one cutting off the first.
    // ---------------------------------------------------------------
    private static void PlaySound(string fileName)
    {
        string path = @"C:\Windows\Media\" + fileName;

        // If the file is missing on this computer, just skip the sound.
        if (File.Exists(path))
        {
            SoundPlayer player = new SoundPlayer(path);
            player.PlaySync();
        }
    }

    // ---------------------------------------------------------------
    //  Button event handlers
    // ---------------------------------------------------------------
    private void singleButton_Click(object sender, EventArgs e)
    {
        outputListBox.Items.Add("1. Calling chimeHandler:");
        chimeHandler("Low battery");   // calls PlayChime()
    }

    private void composedButton_Click(object sender, EventArgs e)
    {
        outputListBox.Items.Add("2. Calling combinedHandler:");
        CallCombined();               // calls PlayChime(), then FlashLight()
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        outputListBox.Items.Add("3. Added ShowPopup with +=");
        combinedHandler += ShowPopup;  // add a third method
        CallCombined();
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
        outputListBox.Items.Add("4. Removed FlashLight with -=");
        combinedHandler -= FlashLight; // take a method out
        CallCombined();
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
        outputListBox.Items.Add("5. copyHandler = combinedHandler");

        // Assigning one delegate to another with =
        AlertHandler copyHandler;
        copyHandler = combinedHandler;

        // copyHandler now refers to the same method(s)
        if (copyHandler != null)
        {
            copyHandler("Copied delegate");
        }
    }

    // If every method has been removed, the delegate is null,
    // and calling it would crash the program. So check first.
    private void CallCombined()
    {
        if (combinedHandler != null)
        {
            combinedHandler("Low battery");
        }
        else
        {
            outputListBox.Items.Add("  (no methods left in the delegate)");
        }
    }
}
