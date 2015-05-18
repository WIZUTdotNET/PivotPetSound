using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotPetSounds.ViewModels
{
    public class SoundModel
    {
        public SoundGroup Animals { get; set; }
        public SoundGroup Cartoons { get; set; }
        public SoundGroup Taunts { get; set; }
        public SoundGroup Warnings { get; set; }

        public bool IsDataLoaded { get; set; }

        public void LoadData()
        {
            Animals = CreateAnimalsGroup();
            Cartoons = CreateCartoonsGroup();
            Taunts = CreateTauntsGroup();
            Warnings = CreateWarningsGroup();

            IsDataLoaded = true;
        }

        private SoundGroup CreateWarningsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Warnings";

            string basePath = "Assets/Audio/Warnings/";

            String[] titles = new String[13];
            titles[0] = "Air horn";
            titles[1] = "Air Raid";
            titles[2] = "Alarm Clock - Bell";
            titles[3] = "Alarm Clock - Electric";
            titles[4] = "Backing up";
            titles[5] = "Bell - Church";
            titles[6] = "Bell - School";
            titles[7] = "Fog horn";
            titles[8] = "Glass breaking";
            titles[9] = "Missle alert";
            titles[10] = "Police - UK";
            titles[11] = "Police - US";
            titles[12] = "Vuvuzela";

            for (int i = 0; i < titles.Count(); i++)
            {
                data.Items.Add(new SoundData
                {
                    Title = titles[i],
                    FilePath = basePath + titles[i] + ".wav"
                });
            }

            return data;
        }

        private SoundGroup CreateTauntsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Taunts";

            string basePath = "Assets/Audio/Taunts/";

            String[] titles = new String[13];
            titles[0] = "Cackle";
            titles[1] = "Clock Ticking";
            titles[2] = "Dial up";
            titles[3] = "Drum roll";
            titles[4] = "Elevator Music";
            titles[5] = "Laugh - Evil";
            titles[6] = "Laugh";
            titles[7] = "Sad Trombone";
            titles[8] = "Sarcastic Ooo";
            titles[9] = "Sigh";
            titles[10] = "Snore";
            titles[11] = "Wrong Price";
            titles[12] = "Yawn";

            for (int i = 0; i < titles.Count(); i++)
            {
                data.Items.Add(new SoundData
                {
                    Title = titles[i],
                    FilePath = basePath + titles[i] + ".wav"
                });
            }

            return data;
        }

        private SoundGroup CreateCartoonsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Cartoons";

            string basePath = "Assets/Audio/Cartoons/";

            String[] titles = new String[6];
            titles[0] = "Boing";
            titles[1] = "Bronk";
            titles[2] = "Bugle charge";
            titles[3] = "Laser";
            titles[4] = "Out Here";
            titles[5] = "Splat";

            for (int i = 0; i < titles.Count(); i++)
            {
                data.Items.Add(new SoundData
                {
                    Title = titles[i],
                    FilePath = basePath + titles[i] + ".wav"
                });
            }

            return data;
        }

        private SoundGroup CreateAnimalsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Animals";

            string basePath = "Assets/Audio/Animals/";

            String[] titles = new String[14];
            titles[0] = "Cat Kitten";
            titles[1] = "Cat Meow";
            titles[2] = "Chimpanzee";
            titles[3] = "Cow";
            titles[4] = "Crickets";
            titles[5] = "Dog";
            titles[6] = "Dolphin";
            titles[7] = "Duck";
            titles[8] = "Horse Gallop";
            titles[9] = "Horse Walk";
            titles[10] = "Lion";
            titles[11] = "Pig";
            titles[12] = "Rooster";
            titles[13] = "Sheep";

            for (int i = 0; i < titles.Count(); i++)
            {
                data.Items.Add(new SoundData
                {
                    Title = titles[i],
                    FilePath = basePath + titles[i] + ".wav"
                });
            }

            return data;
        }
    }
}
