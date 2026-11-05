using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Guide12Examples.Models;

/// <summary>
/// Guide 12, Section 1: Uses reflection to show where a control sits in the
/// Object → MarshalByRefObject → Component → Control family tree,
/// how many public properties it exposes, and what its default event is.
/// </summary>
public static class ControlInspector
{
    /// <summary>Returns the type and all of its ancestors, child first.</summary>
    public static IReadOnlyList<Type> GetInheritanceChain(Type type)
    {
        List<Type> chain = new List<Type>();
        Type? current = type;

        while (current != null)
        {
            chain.Add(current);
            current = current.BaseType;
        }

        return chain;
    }

    /// <summary>Counts the public instance properties, inherited ones included.</summary>
    public static int CountPublicProperties(Type type) =>
        type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Length;

    /// <summary>
    /// The default event is the one Visual Studio creates a handler for when
    /// you double-click the control in the Form Designer. Controls declare it
    /// with the [DefaultEvent] attribute, which TypeDescriptor can read.
    /// </summary>
    public static string GetDefaultEventName(Type type) =>
        TypeDescriptor.GetDefaultEvent(type)?.Name ?? "(none)";

    /// <summary>Builds a multi-line report about one control.</summary>
    public static string Describe(Control control)
    {
        Type type = control.GetType();
        StringBuilder report = new StringBuilder();

        report.AppendLine($"Control name : {control.Name}");
        report.AppendLine($"Type         : {type.FullName}");
        report.AppendLine();

        report.AppendLine("Inheritance chain (child -> parent):");
        report.AppendLine("  " + string.Join(" -> ", GetInheritanceChain(type).Select(t => t.Name)));
        report.AppendLine();

        int propertyCount = CountPublicProperties(type);
        report.AppendLine($"Public properties : {propertyCount}  (Control alone has {CountPublicProperties(typeof(Control))})");
        report.AppendLine($"Default event     : {GetDefaultEventName(type)}  (double-click it in the designer to get this handler)");
        report.AppendLine();

        report.AppendLine($"is Control?            {control is Control}");
        report.AppendLine($"is Component?          {control is Component}");
        report.AppendLine($"is MarshalByRefObject? {control is MarshalByRefObject}");
        report.AppendLine();

        report.AppendLine("A few properties every control inherits from Control:");
        report.AppendLine($"  Font      = {control.Font.Name}, {control.Font.SizeInPoints}pt");
        report.AppendLine($"  ForeColor = {control.ForeColor.Name}");
        report.AppendLine($"  Width     = {control.Width}");
        report.AppendLine($"  Height    = {control.Height}");
        report.AppendLine($"  Location  = {control.Location}");

        return report.ToString();
    }
}
