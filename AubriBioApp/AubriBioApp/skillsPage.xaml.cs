using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AubriBioApp
{
    public partial class skillsPage : ContentPage
    {
        public ObservableCollection<Skill> Skills { get; set; }
        void Handle_Clicked(object sender, System.EventArgs e)
        {    
        }

        public skillsPage()
        {
            InitializeComponent();
            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill {Icon = "BackendButton.png"});
            this.Skills.Add(new Skill {Description = "skill1", Name = "- C++" });
            this.Skills.Add(new Skill {Description = "skill2", Name = "- C#" });

            skills.ItemsSource = this.Skills;
        }
    }

    public class Skill
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
