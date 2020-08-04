using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_InfraStructure.Database
{
    public class BitzenSeed
    {
        public void Load()
        {
            //method that is responsible to create basic structure
            //of database:
            StringBuilder commandContainer = new StringBuilder();
            commandContainer.Append("create table Login(id int auto_increment primary key,name varchar(100), password varchar(100), email varchar(50) );");

            commandContainer.Append("create table Vehicle(id int auto_increment primary key,brand varchar(100), model varchar(100), year int, plaque varchar(20), transporttype char(1), fueltype char(1) , kilometers int, userid int, photopath varchar(2000) );");

            commandContainer.Append("create table Supply(id int auto_increment primary key,kmsupply int, quantity int, value float, datasupply date, userid int, fueltype char(1) , vehicleid int );");


        }
    }

}
