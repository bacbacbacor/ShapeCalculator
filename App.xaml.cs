﻿namespace ShapeCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TriangleMenu();
        }
    }
}