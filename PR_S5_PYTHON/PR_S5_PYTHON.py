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

ejercicio1()
