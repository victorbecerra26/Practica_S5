import math

def ejercicio1():
    print("===== SISTEMA DE DESCUENTOS =====")
    costoProducto = float(input("Ingrese el costo unitario del artículo: "))
    rebaja = 0
    bonoExtra = 0

    print("\nSeleccione el tipo de descuento:\n[1] Estudiante\n[2] Empleado\n[3] Cliente frecuente")
    tipoUsuario = int(input("\nIngrese su opción: "))

    if costoProducto >= 0:
        if 1 <= tipoUsuario <= 3:
            if tipoUsuario == 1:
                rebaja = costoProducto * 0.10
            elif tipoUsuario == 2:
                rebaja = costoProducto * 0.15
            else:
                rebaja = costoProducto * 0.20
        else:
            print("\nERROR: Tipo de descuento inválido.")

        subtotal = costoProducto - rebaja

        if costoProducto > 500:
            bonoExtra = subtotal * 0.05

        pagoFinal = subtotal - bonoExtra

        print(f"\nTotal a pagar luego del descuento: {pagoFinal:.2f}")
    else:
        print("\nERROR: El costo ingresado no es válido.")

def ejercicio2():
    calificacion = int(input("Ingrese una calificación entre 0 y 20: "))
    respuesta = ""
    nota = ""

    if 0 <= calificacion <= 20:
        match calificacion:
            case valor if 0 <= valor <= 10:
                respuesta = "Desaprobado"
            case valor if 11 <= valor <= 13:
                respuesta = "Regular"
            case valor if 14 <= valor <= 17:
                respuesta = "Bueno"
            case _:
                respuesta = "Excelente"

        if calificacion >= 14 and calificacion % 2 == 0:
            nota = "Buen desempeño con nota par"

        if calificacion < 11 or calificacion % 2 != 0:
            nota = "Requiere mejorar"

        print(f"Su clasificación es: {respuesta} + {nota}")
        print(f"\nRaíz cuadrada de la calificación: {math.sqrt(calificacion):.1f}")
        print("Calificación elevada al cubo: ", math.pow(calificacion, 3))
    else:
        print("\nERROR: Calificación fuera del rango permitido.")

ejercicio2()
