﻿using System;
using System.Collections.Generic;
using System.Text;
using typebank.Funcionarios;

namespace typebank.Sistemas
{
    public interface IAutenticar // Uma interface contém apenas as assinaturas de métodos, propriedades, eventos ou indexadores.
    { 
        bool Autenticar(string senha); //Em uma interface todos os metodos são public, sendo assim não precisando utilizar o plublic.
    }
}
