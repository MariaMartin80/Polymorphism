using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The showanimal method accepts an animal
        //object as an argument. It displays the object's
        //species and calls its makesound method.
        private void showAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular animal");
            showAnimalInfo(myAnimal);
        }

        private void createDogButton_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is " + myDog.Name);
            showAnimalInfo(myDog);
        }

        private void createCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is " + myCat.Name);
            showAnimalInfo(myCat);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
