using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_02
{
    internal class Binder
    {
        private Owner owner;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox lastNameTextBox;
        

        public Binder(Owner owner, TextBox surname, TextBox name, TextBox lastname)
        {
            this.owner = owner;
            this.surnameTextBox = surname;
            this.nameTextBox = name;
            this.lastNameTextBox = lastname;
        }

        public void SetupDataBinding()
        {
            surnameTextBox.DataBindings.Add("writeSurname", owner, "surname");
            nameTextBox.DataBindings.Add("writeName", owner, "name");

            if (lastNameTextBox != null)
            {
                lastNameTextBox.DataBindings.Add("writeLastName", owner, "lastName");
            }
        }
    }
}
