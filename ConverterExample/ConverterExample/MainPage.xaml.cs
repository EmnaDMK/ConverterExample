using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConverterExample
{
    public partial class MainPage : ContentPage
    {
        private bool dogChecked = false;

        public bool DogChecked
        {



            get { return dogChecked; }



            set
            {
                //dogChecked = value;
                SetProperty(ref dogChecked, value);
            }



        }

        private bool catChecked = false;

        public bool CatChecked
        {



            get { return catChecked; }



            set
            {
                //catChecked = value;
                SetProperty(ref catChecked, value);
            }



        }

        private bool birdChecked = false;

        public bool BirdChecked
        {



            get { return birdChecked; }



            set
            {
                //birdChecked = value;
                SetProperty(ref birdChecked, value);
            }



        }

        protected bool SetProperty<T>(ref T backingStore, T value,



            [CallerMemberName] string propertyName = "",



            Action onChanged = null)



        {



            if (EqualityComparer<T>.Default.Equals(backingStore, value))



                return false;


            backingStore = value;



            onChanged?.Invoke();



            OnPropertyChanged(propertyName);



            return true;



        }

        private List<ImageGallery> DogImages;

        private List<ImageGallery> CatImages;

        private List<ImageGallery> BirdImages;

        private List<ImageGallery> ListImages;

        List<ImageGallery> _selectedAnimals = new List<ImageGallery>();


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;



            DogImages = new List<ImageGallery>

            {

                new ImageGallery

                {

                    category = "Dogs",

                    source = "dog.jpg"

                },

                new ImageGallery

                {

                    category = "Dogs",

                    source = "dog2.jpg"

                },

                new ImageGallery

                {

                    category = "Dogs",

                    source = "dog3.jpg"

                }

            };

            CatImages = new List<ImageGallery>

            {

                new ImageGallery

                {

                    category = "Cats",

                    source = "Cat.jpg"

                },

                new ImageGallery

                {

                    category = "Cats",

                    source = "cat2.jpg"

                },

                new ImageGallery

                {

                    category = "Cats",

                    source = "cat3.jpg"

                }

            };

            BirdImages = new List<ImageGallery>

            {

                new ImageGallery

                {

                    category = "Birds",

                    source = "bird1.jpg"

                },

                new ImageGallery

                {

                    category = "Birds",

                    source = "bird2.jpg"

                },

                new ImageGallery

                {

                    category = "Birds",

                    source = "bird3.jpg"

                }

            };

            ListImages = new List<ImageGallery>
            {
                new ImageGallery {category = "Birds", source = "bird1.jpg"},
                new ImageGallery {category = "Birds", source = "bird2.jpg"},
                new ImageGallery {category = "Birds", source = "bird3.jpg"},
                new ImageGallery {category = "Cats", source = "Cat.jpg"},
                new ImageGallery {category = "Cats", source = "cat2.jpg"},
                new ImageGallery {category = "Cats", source = "cat3.jpg"},
                new ImageGallery {category = "Dogs", source = "dog.jpg"},
                new ImageGallery {category = "Dogs", source = "dog2.jpg"},
                //new ImageGallery {category = "Dogs", source = "dog3.jpg"}
            };


            AnimalListView.ItemsSource = ListImages;


        }

        private void OnCheckDog(object sender, EventArgs e)
        {
            if (DogChecked == false)
            {
                DogChecked = true;
                _selectedAnimals.Clear();
                foreach (var variable in ListImages)

                {

                    if (variable.category.Equals("Dogs"))
                    {
                        _selectedAnimals.Add(variable);
                    }


                }

                AnimalListView.ItemsSource = _selectedAnimals;

            }
            else
            {
                DogChecked = false;

                AnimalListView.ItemsSource = ListImages;

            }
        }


        private void OnCheckCat(object sender, EventArgs e)
        {
            if (CatChecked == false)
            {
                CatChecked = true;
                _selectedAnimals.Clear();
                foreach (var variable in ListImages)

                {

                    if (variable.category.Equals("Cats"))
                    {
                        _selectedAnimals.Add(variable);
                    }


                }

                AnimalListView.ItemsSource = _selectedAnimals;

            }
            else
            {
                CatChecked = false;
               
                AnimalListView.ItemsSource = ListImages;

            }
        }

        private void OnCheckBird(object sender, EventArgs e)
        {
            if (BirdChecked == false)
            {
                BirdChecked = true;
                _selectedAnimals.Clear();
                foreach (var variable in ListImages)

                {

                    if (variable.category.Equals("Birds"))
                    {
                        _selectedAnimals.Add(variable);
                    }


                }

                AnimalListView.ItemsSource = _selectedAnimals;

            }

            else
            {
                BirdChecked = false;
                //foreach (var variable in ListImages)

                //{

                //    if (variable.category.Equals("Birds"))
                //    {
                //        _selectedAnimals.Remove(variable);
                //    }

          
                //}

                AnimalListView.ItemsSource = ListImages;

            }
        }




        //    private void Button_OnClick(object sender, EventArgs e)
        //    {

        //        if (b2.Image == "unchecked.png")

        //        {

        //            b2.Image = "checked.png";

        //        foreach (var VARIABLE in CatImages)

        //        {

        //            AnimalListView.ItemsSource = CatImages;

        //        }


        //        //AnimalListView.ItemsSource = CatImages;
        //            if (b3.Image == "checked.png" && (b4.Image == "unchecked.png"))
        //            {
        //                AnimalListView.ItemsSource = CatImages.Concat(BirdImages);
        //            }
        //            else if (b4.Image == "checked.png" && (b3.Image == "unchecked.png"))
        //        {
        //            AnimalListView.ItemsSource = CatImages.Concat(DogImages);
        //        }
        //        else if ((b4.Image == "checked.png") && (b3.Image == "checked.png"))
        //            {
        //                AnimalListView.ItemsSource = ListImages;
        //            }
        //            else if ((b4.Image == "unchecked.png") && (b3.Image == "unchecked.png")&& (b2.Image == "checked.png"))
        //            {
        //            AnimalListView.ItemsSource = CatImages;
        //        }
        //    }


        //    else
        //    {

        //        b2.Image = "unchecked.png";
        //        AnimalListView.ItemsSource = ListImages;
        //    }

        //}

        //private void Button_OnClickb3(object sender, EventArgs e)
        //            {

        //                if (b3.Image == "unchecked.png")

        //                {

        //                    b3.Image = "checked.png";
        //                    AnimalListView.ItemsSource = BirdImages;

        //                    if (b2.Image == "checked.png" && (b4.Image == "unchecked.png"))
        //                    {
        //                        AnimalListView.ItemsSource = BirdImages.Concat(CatImages);
        //                    }
        //                    else if (b4.Image == "checked.png" && (b2.Image == "unchecked.png"))
        //                    {
        //                        AnimalListView.ItemsSource = BirdImages.Concat(DogImages);
        //                    }
        //                    else if ((b4.Image == "checked.png") && (b2.Image == "checked.png"))
        //                    {
        //                        AnimalListView.ItemsSource = ListImages;
        //                    }


        //                }
        //                else
        //                {
        //                    if (b3.Image == "unchecked.png")
        //                    {
        //                    AnimalListView.ItemsSource = ListImages;
        //                    }

        //                    if ((b4.Image == "unchecked.png") && (b2.Image == "unchecked.png") &&
        //                        (b3.Image == "checked.png"))
        //                    {
        //                        AnimalListView.ItemsSource = BirdImages;
        //                    }
        //                }

        //            }
        //        private void Button_OnClickb4(object sender, EventArgs e)
        //        {

        //            if (b4.Image == "unchecked.png")

        //            {

        //                b4.Image = "checked.png";
        //                AnimalListView.ItemsSource = DogImages;
        //                if (b3.Image == "checked.png")
        //                {
        //                    AnimalListView.ItemsSource = DogImages.Concat(BirdImages);

        //                }
        //                else if (b2.Image == "checked.png")
        //            {
        //                AnimalListView.ItemsSource = DogImages.Concat(CatImages);
        //            }
        //            else if ((b3.Image == "checked.png") && (b2.Image == "checked.png"))
        //            {
        //                AnimalListView.ItemsSource = ListImages;
        //            }
        //                else if (b3.Image == "checked.png")
        //                {
        //                    AnimalListView.ItemsSource = DogImages.Concat(BirdImages);
        //                }
        //            }

        //            else 
        //            {

        //                b4.Image = "unchecked.png";
        //                AnimalListView.ItemsSource = ListImages;
        //            }

        //        }

        //    }
        //}



        //private void Button_OnClicked(object sender, EventArgs e)
        //{
        //      b1.BackgroundColor = Color.Blue;
        //        Device.StartTimer(TimeSpan.FromSeconds(0.25), () =>
        //        {
        //            b1.BackgroundColor = Color.Red;
        //            return false;
        //        });
        //}



    }
}





