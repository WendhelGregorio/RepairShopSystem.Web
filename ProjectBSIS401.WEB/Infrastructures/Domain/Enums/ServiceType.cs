using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Enums
{
    public enum ServiceType
    {

        [Description(" Android Phone")]
        AndroidPhone ,


        [Description(" Android Tablet")]
        AndroidTablet,


        [Description(" IPhone")]
        IPhone,


       [Description(" IPad ")]
        IPad,


        [Description(" Laptop ")]
        Laptop,

        [Description(" Laptop ")]
        Desktop,

        [Description(" Printer ")]
        Printer,




        //[Description(" Computer Setup")]
        //ComputerSetUp ,


        //[Description("Data Recovery")]
        //DataRecovery,

        //[Description("Virus Removal")]
        //VirusRemoval,

        //[Description("Software Update")]
        //SoftwareUpdate ,


        //[Description("KeyBoard Replacement")]
        //KeyBoardReplacement,

        //[Description("Diagnostic Evaluation")]
        //DiagnosticEvaluation,

        //[Description("Battery Replacement")]
        //BatteryReplacement,

        //[Description("Hard Drive Recovery")]
        //HardDriveRecovery,

        //[Description("Charge Port Replacement")]
        //ChargePortReplacement,

        //[Description("Liquid Damage")]
        //LiquidDamage,

        //[Description("OS Updgrade")]
        //OSUpdgrade,

        //[Description("Tune Ups")]
        //TuneUps,

        //[Description("Ram Upgrades")]
        //RamUpgrades,


        //[Description("Hard Drive Upgrades")]
        //HardDriveUpgrades,


        //[Description("LCD Replacements")]
        //LCDReplacements,


        //[Description("LCD Digitizer Replacement")]
        //LCDDigitizerReplacement,

        //[Description("Unlock")]
        //Unlock,

        //[Description("Touch Screen Repair")]
        //TouchScreenRepair,


        //[Description("Charge Port Repair")]
        //ChargePortRepair,


        //[Description("Screen Repair")]
        //HTCScreenRepair,


        //[Description("Speaker Repair")]
        //SpeakerRepair,

        //[Description("Buttons Not Working ")]
        //ButtonsNotWorking,

    }
}
