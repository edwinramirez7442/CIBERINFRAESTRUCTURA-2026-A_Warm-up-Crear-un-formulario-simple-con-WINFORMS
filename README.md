# CIBERINFRAESTRUCTURA-2026-A_Warm-up-Crear-un-formulario-simple-con-WINFORMS

# Validador de Contraseñas con WinForms 

Este proyecto es una aplicación de escritorio diseñada para reforzar conocimientos en el entorno de **Visual Studio** y la manipulación de controles de **Windows Forms**. La aplicación implementa una validación estricta de contraseñas mediante lógica condicional y expresiones regulares (Regex).

---

##  Metodología de Desarrollo

### 1. Configuración del Entorno
* Se seleccionó la plantilla **Windows Form App (.NET Framework)** en Visual Studio.
* El proyecto se nombró formalmente como `Ciber_Infrestructura_2026-A_HolaMundo`.

**Creación del Proyecto**
<img width="1119" height="724" alt="Captura de pantalla 2026-03-08 164350" src="https://github.com/user-attachments/assets/a6f80412-dc71-4f38-b8f2-c5b4847e3993" />

### 2. Diseño de la Interfaz (UI)
Se utilizaron los siguientes componentes del **Toolbox** para construir el formulario:
* **Labels**: Se añadieron dos etiquetas con los textos "Escribe Contraseña:" y "Repite Contraseña:", configuradas en negritas.
* **TextBoxes**: Se incorporaron dos campos de entrada nombrados `textPassword1` y `textPassword2`.
* **Button**: Se agregó un botón de acción con el texto "VALIDAR" y el nombre de objeto `bttValidar`.

**Interfaz de Usuario**

<img width="532" height="261" alt="Captura de pantalla 2026-03-08 165627" src="https://github.com/user-attachments/assets/69482134-ffe0-430e-be84-69c098e9fcb1" />

### 3. Lógica de Validación (Código C#)
El comportamiento del programa se definió mediante el evento `Click` del botón, integrando las siguientes validaciones:

* **Validación de Vacío**: El sistema verifica que ambos campos contengan texto antes de proceder.
* **Validación de Igualdad**: Se utiliza una estructura `if-else` para confirmar que ambas entradas coincidan exactamente.
* **Validación de Complejidad (Regex)**: Se implementó una expresión regular que evalúa el cumplimiento de las reglas:
    * Al menos una letra mayúscula.
    * Al menos una letra minúscula.
    * Al menos un número.
    * Al menos un símbolo o carácter especial.

**Lógica Regex**

<img width="1075" height="514" alt="Captura de pantalla 2026-03-08 173606" src="https://github.com/user-attachments/assets/7b4dcd74-6326-40ba-acda-519b43886e4c" />
<img width="963" height="228" alt="Captura de pantalla 2026-03-08 165555" src="https://github.com/user-attachments/assets/d526482b-c3a4-4b12-b455-254404a9a7cf" />

---

##  Pruebas y Resultados
La aplicación muestra diferentes mensajes según el estado de la validación:

1.  **Campos vacíos**: "Ambos campos deben contener texto para validar".
  
<img width="530" height="440" alt="Captura de pantalla 2026-03-08 165648" src="https://github.com/user-attachments/assets/3301d29f-e16f-4e6a-b140-00b01de910b1" />

2.  **No coincidentes**: "Las contraseñas deben ser iguales".
  
<img width="528" height="429" alt="Captura de pantalla 2026-03-08 165718" src="https://github.com/user-attachments/assets/b7b8b20c-70d0-41f9-9845-4327845e4e2e" />

3.  **Falla de complejidad**: "La contraseña no cumple con las especificaciones".
 
<img width="529" height="431" alt="Captura de pantalla 2026-03-08 165751" src="https://github.com/user-attachments/assets/7a7f7362-aa8d-4cd0-a058-b4f845cca9d3" />

4.  **Validación exitosa**: "Contraseña valida".
    
<img width="529" height="431" alt="Captura de pantalla 2026-03-08 165832" src="https://github.com/user-attachments/assets/33dc7899-176e-43e5-89cc-2bd541a060be" />

---

## Conclusión
A través de este proyecto se logró dominar la creación de formularios simples en WinForms, la gestión de eventos de usuario y la implementación de seguridad básica mediante **Regex**.

---
**Desarrollado por:** Edwin Ivan Ramirez Gomez. 
**Institución:** Universidad de Guadalajara - CUCEI.
