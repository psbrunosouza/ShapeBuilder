using ShapeBuilder.Entities.Enums;

namespace ShapeBuilder.Entities {
    abstract class Shape {
    
        public Color Color { get; set; }

        public Shape() {

        }

        public Shape(Color color) {
            Color = color;
        }

        //Metodos abstratos nao precisam ser implementados dentro da classe abstrata, 
        //pois serao obrigatoriamente implementados nas sub-classes
        public abstract double Area();

    }
}
