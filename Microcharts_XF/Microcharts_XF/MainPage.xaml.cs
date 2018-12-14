using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StepEntry = Microcharts.Entry;
using SleepEntry = Microcharts.Entry;
using CalorieEntry = Microcharts.Entry;
using Microcharts;

namespace Microcharts_XF
{
    public partial class MainPage : ContentPage
    {

        /** Durum Ekranı Adım Sayar microcharts yapısı için örnek data. */
        List<StepEntry> entriesStep = new List<StepEntry>
        {
            new StepEntry(1000)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Pazartesi",
                ValueLabel="1000"
            },
            new StepEntry(1450)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Salı",
                ValueLabel="1450"
            },
            new StepEntry(950)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Çarşamba",
                ValueLabel="950"
            },
            new StepEntry(850)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Perşembe",
                ValueLabel="350"
            },
             new StepEntry(4536)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Cuma",
                ValueLabel="4536"
            },
              new StepEntry(2584)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Cumartesi",
                ValueLabel="564"
            },
               new StepEntry(1453)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Pazar",
                ValueLabel="350"
            }
        };


        /** Durum Ekranı Uyku microcharts yapısı için örnek data. */
        List<SleepEntry> entriesSleep = new List<SleepEntry>
        {
            new SleepEntry(40)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Pazartesi",
                ValueLabel="%40"
            },
            new SleepEntry(60)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Salı",
                ValueLabel="%60"
            },
            new SleepEntry(54)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Çarşamba",
                ValueLabel="%54"
            },
            new SleepEntry(89)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Perşembe",
                ValueLabel="%89"
            },
             new SleepEntry(75)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Cuma",
                ValueLabel="%75"
            },
              new SleepEntry(64)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Cumartesi",
                ValueLabel="%64"
            },
               new SleepEntry(24)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Pazar",
                ValueLabel="%24"
            }
        };


        /** Durum Ekranı AKalori microcharts yapısı için örnek data. */
        List<CalorieEntry> entriesCalorie = new List<CalorieEntry>
        {
            new CalorieEntry(1453)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Pazartesi",
                ValueLabel="1453"
            },
            new CalorieEntry(1889)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Salı",
                ValueLabel="1889"
            },
            new CalorieEntry(1600)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Çarşamba",
                ValueLabel="1600"
            },
            new CalorieEntry(809)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Perşembe",
                ValueLabel="809"
            },
             new CalorieEntry(1075)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Cuma",
                ValueLabel="1075"
            },
              new CalorieEntry(985)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Cumartesi",
                ValueLabel="985"
            },
               new CalorieEntry(1200)
            {
                Color=SKColor.Parse("#ffc400"),
                Label="Pazar",
                ValueLabel="1200"
            }
        };

        public MainPage()
        {
            InitializeComponent();

            StepChartActivity.Chart = new RadialGaugeChart
            {
                Entries = entriesStep,
                LabelTextSize = 20
            };

            SleepChartActivity.Chart = new RadialGaugeChart
            {
                Entries = entriesSleep,
                LabelTextSize = 20
            };

            CalorieChartActivity.Chart = new RadialGaugeChart
            {
                Entries = entriesCalorie,
                LabelTextSize = 20
            };
        }
    }
}
