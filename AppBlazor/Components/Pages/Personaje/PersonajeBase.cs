using System.Collections;

namespace AppBlazor.Components {
    public class PersonajeBase
    {
        public int Id {get; set;}
        public string? Nombre {get; set;}
        public int Nivel {get; set;}
        public string? Tipo {get; set;}
        public double Salud {get; set;}
        public double Energia {get; set;}
        public double Fuerza {get; set;}
        public double Inteligencia {get; set;}
        public double Agilidad {get; set;}
        public double Defensa {get; set;}
        public double Resistencia {get; set;}
        public double Experiencia {get; set;}
        public string? Inventario {get; set;}

        public Personaje(int _id, string _nombre, int _nivel, string _tipo, double _salud, 
        double _energia, double _fuerza, double _inteligencia, double _agilidad, double _defensa, 
        double _resistencia, double _experiencia, string _inventario) {
            Id = _id;
            Nombre = _nombre;
            Nivel = _nivel;
            Tipo = _tipo;
            Salud = _salud;
            Energia = _energia; 
            Fuerza = _fuerza;
            Inteligencia = _inteligencia;
            Agilidad = _agilidad;
            Defensa = _defensa;
            Resistencia = _resistencia; 
            Experiencia = _experiencia;
            Inventario = _inventario;
        }

    }
}