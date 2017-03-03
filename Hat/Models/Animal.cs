//Автор игры "Кто под шляпой" - Дмитриенко Ю.Е.

using Catel.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hat.Models
{
    public class Animal : ModelBase
    {

        private static List<Animal> randomAnimals;
        private static List<Animal> selectedAnimals = new List<Animal>();
        

        public string Name
        {
            get { return GetValue<string>(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

       
        public static readonly PropertyData NameProperty = RegisterProperty("Name", typeof(string), string.Empty);


        
        public BitmapImage Image
        {
            get { return GetValue<BitmapImage>(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

       
        public static readonly PropertyData ImageProperty = RegisterProperty("Image", typeof(BitmapImage), null);

       
        public string Description
        {
            get { return GetValue<string>(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

       
        public static readonly PropertyData DescriptionProperty = RegisterProperty("Description", typeof(string));



        public static List<Animal> GetAnimals()
        {
            var animals = new List<Animal>();

            int counter = 0;
            string line;

            var file = new StreamReader(Directory.GetCurrentDirectory() + "/animals.txt");
            while((line = file.ReadLine()) != null)
            {

                String[] words = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                animals.Add(new Animal {Image = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/" + words[0], 
                    UriKind.Absolute)), Name = words[1], Description = words[2] });
                counter++;
            }

            file.Close();

            randomAnimals = new List<Animal>();

            Random rand = new Random();

            
            for (int i = 0; i < 4; i++)
            {
                var select = animals[rand.Next(animals.Count)];
                if (randomAnimals.Find(x => x.Name.Equals(select.Name))== null)
                {
                    if (selectedAnimals.Find(x => x.Name.Equals(select.Name))== null)
                    {
                        randomAnimals.Add(new Animal() { Image = select.Image, Name = select.Name, Description = select.Description });
                    }

                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
                

            }

            if (selectedAnimals.Count.Equals(counter - 4))
            {
                selectedAnimals.Clear();
            }
            
            return randomAnimals;
        }



        public static Animal GetRandomCurrent(){
            Random rand = new Random();
            Animal random = new Animal(); 
            for (int i = 0; i < 1; i++)
            {
                if (!selectedAnimals.Contains(random))
                {
                    random = randomAnimals[rand.Next(randomAnimals.Count)];
                }
                else
                {
                    i--;
                }
            }
            selectedAnimals.Add(new Animal() { Image = random.Image, Name = random.Name, Description = random.Description });
            return random;
        }


        


        


    }
}
