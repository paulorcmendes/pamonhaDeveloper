﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha
{
    class Pet
    {


        private String nome;
        private String dataDeNascimento;
        private String raca;
        private String rga;
        private String dono;


        public String Nome
        {


            get
            {
                return this.nome;
            }



            set
            {
                this.nome = value;
            }


        }

        public String DataDeNascimento
        {


            get
            {
                return this.dataDeNascimento;
            }



            set
            {
                this.dataDeNascimento = value;
            }


        }

        public String Raca
        {


            get
            {
                return this.raca;
            }



            set
            {
                this.raca = value;
            }


        }

        public String RGA
        {


            get
            {
                return this.rga;
            }



            set
            {
                this.rga = value;
            }


        }


        public String Dono
        {


            get
            {
                return this.dono;
            }



            set
            {
                this.dono = value;
            }


        }







    }
}
