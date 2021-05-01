# Laboratorio 4: Aplicacion de patrón de diseño Estructural

Implementación de Patrón Estructural implementado en C# y haciendo uso de repl.it

Este es un problema que plantea el desarrollo de una calculadora básica la cuál permite realizar operaciones matemáticas de varios tipos.

En el main se resuelve esta operación matemática:

```
((1 * 2) + (2 * 2) + (3 * 2) + (4 * 2) + (5 * 2) + (6 * 2) + (7 * 2) + (8 * 2) + (9 * 2) + (10 * 2)) + ((5 + 4) + (1 * 2) + (8 / 3) + (4 / 7) + (3 * 1) + (6 - 12))
```

La clase Sumatoria(Composite) calcula la suma de todas las operaciones matemáticas que tiene en su lista.

La clase Sumar(Leaf1) calcula la suma de dos números.

La clase Restar(Leaf2) calcula la suma de dos números.

La clase Multiplicar(Leaf3) calcula la suma de dos números.

La clase Dividir(Leaf4) calcula la suma de dos números.