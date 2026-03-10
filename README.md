# CIBERINFRAESTRUCTURA-2026-A_Warm-up-Crear-un-formulario-simple-con-WINFORMS

# Validador de Contraseñas con WinForms 🔐

Este proyecto es una aplicación de escritorio diseñada para reforzar conocimientos en el entorno de **Visual Studio** y la manipulación de controles de **Windows Forms**. La aplicación implementa una validación estricta de contraseñas mediante lógica condicional y expresiones regulares (Regex).

---

## 🛠️ Metodología de Desarrollo

### 1. Configuración del Entorno
* Se seleccionó la plantilla **Windows Form App (.NET Framework)** en Visual Studio.
* El proyecto se nombró formalmente como `Ciber_Infrestructura_2026-A_HolaMundo`.

![Creación del Proyecto]

*(Referencia a la creación del proyecto con el template .NET Framework)*

### 2. Diseño de la Interfaz (UI)
Se utilizaron los siguientes componentes del **Toolbox** para construir el formulario:
* **Labels**: Se añadieron dos etiquetas con los textos "Escribe Contraseña:" y "Repite Contraseña:", configuradas en negritas.
* **TextBoxes**: Se incorporaron dos campos de entrada nombrados `textPassword1` y `textPassword2`.
* **Button**: Se agregó un botón de acción con el texto "VALIDAR" y el nombre de objeto `bttValidar`.

![Interfaz de Usuario](img/fig7_interfaz.png)
*(Referencia a la ventana de la aplicación de escritorio terminada)*

### 3. Lógica de Validación (Código C#)
El comportamiento del programa se definió mediante el evento `Click` del botón, integrando las siguientes validaciones:

* **Validación de Vacío**: El sistema verifica que ambos campos contengan texto antes de proceder.
* **Validación de Igualdad**: Se utiliza una estructura `if-else` para confirmar que ambas entradas coincidan exactamente.
* **Validación de Complejidad (Regex)**: Se implementó una expresión regular que evalúa el cumplimiento de las reglas:
    * Al menos una letra mayúscula.
    * Al menos una letra minúscula.
    * Al menos un número.
    * Al menos un símbolo o carácter especial.

![Lógica Regex](img/fig6_codigo.png)
*(Referencia a la codificación de condicionales y expresión Regex)*

---

## 🧪 Pruebas y Resultados
La aplicación muestra diferentes mensajes según el estado de la validación:

1.  **Campos vacíos**: "Ambos campos deben contener texto para validar".
2.  **No coincidentes**: "Las contraseñas deben ser iguales".
3.  **Falla de complejidad**: "La contraseña no cumple con las especificaciones".
4.  **Validación exitosa**: "Contraseña valida".

---

## 🎓 Conclusión
A través de este proyecto se logró dominar la creación de formularios simples en WinForms, la gestión de eventos de usuario y la implementación de seguridad básica mediante **Regex**.

---
**Desarrollado por:** Edwin Ivan Ramirez Gomez. 
**Institución:** Universidad de Guadalajara - CUCEI.
