using FreezeBug.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreezeBug.ViewModels;

public class SettingsViewModel
{
    public Setting MinValue { get; set; }

    public Setting MaxValue { get; set; }

    public Setting PrimaryValue { get; set; }

    public Setting SecondaryValue { get; set; }

    public Setting WarningValue { get; set; }

    public Setting CrashValue { get; set; }

}
