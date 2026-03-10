# CIBERINFRAESTRUCTURA-2026-A_Warm-up-Crear-un-formulario-simple-con-WINFORMS

# Validador de Contraseñas con WinForms 🔐

[cite_start]Este proyecto es una aplicación de escritorio diseñada para reforzar conocimientos en el entorno de **Visual Studio** y la manipulación de controles de **Windows Forms**[cite: 3]. [cite_start]La aplicación implementa una validación estricta de contraseñas mediante lógica condicional y expresiones regulares (Regex)[cite: 2, 4].

---

## 🛠️ Metodología de Desarrollo

### 1. Configuración del Entorno
* [cite_start]Se seleccionó la plantilla **Windows Form App (.NET Framework)** en Visual Studio[cite: 7].
* [cite_start]El proyecto se nombró formalmente como `Ciber_Infrestructura_2026-A_HolaMundo`[cite: 9, 12].

![Creación del Proyecto]<img width="1119" height="724" alt="Captura de pantalla 2026-03-08 164350" src="https://github.com/user-attachments/assets/0ed115ae-2397-4aa6-9a9e-25aae07efb34" />

[cite_start]*(Referencia a la creación del proyecto con el template .NET Framework [cite: 8])*

### 2. Diseño de la Interfaz (UI)
Se utilizaron los siguientes componentes del **Toolbox** para construir el formulario:
* [cite_start]**Labels**: Se añadieron dos etiquetas con los textos "Escribe Contraseña:" y "Repite Contraseña:", configuradas en negritas[cite: 13, 14, 17].
* [cite_start]**TextBoxes**: Se incorporaron dos campos de entrada nombrados `textPassword1` y `textPassword2`[cite: 18].
* [cite_start]**Button**: Se agregó un botón de acción con el texto "VALIDAR" y el nombre de objeto `bttValidar`[cite: 20, 25].

![Interfaz de Usuario](img/fig7_interfaz.png)
[cite_start]*(Referencia a la ventana de la aplicación de escritorio terminada [cite: 27])*

### 3. Lógica de Validación (Código C#)
[cite_start]El comportamiento del programa se definió mediante el evento `Click` del botón[cite: 2, 5], integrando las siguientes validaciones:

* [cite_start]**Validación de Vacío**: El sistema verifica que ambos campos contengan texto antes de proceder[cite: 24, 28].
* [cite_start]**Validación de Igualdad**: Se utiliza una estructura `if-else` para confirmar que ambas entradas coincidan exactamente[cite: 25, 30].
* [cite_start]**Validación de Complejidad (Regex)**: Se implementó una expresión regular que evalúa el cumplimiento de las reglas[cite: 4, 6, 23, 25]:
    * [cite_start]Al menos una letra mayúscula[cite: 4, 25].
    * [cite_start]Al menos una letra minúscula[cite: 4, 25].
    * [cite_start]Al menos un número[cite: 4, 25].
    * [cite_start]Al menos un símbolo o carácter especial[cite: 4, 25].

![Lógica Regex](img/fig6_codigo.png)
[cite_start]*(Referencia a la codificación de condicionales y expresión Regex [cite: 25])*

---

## 🧪 Pruebas y Resultados
La aplicación muestra diferentes mensajes según el estado de la validación:

1.  [cite_start]**Campos vacíos**: "Ambos campos deben contener texto para validar"[cite: 28, 29].
2.  [cite_start]**No coincidentes**: "Las contraseñas deben ser iguales"[cite: 30, 31].
3.  [cite_start]**Falla de complejidad**: "La contraseña no cumple con las especificaciones"[cite: 34].
4.  [cite_start]**Validación exitosa**: "Contraseña valida"[cite: 32, 33].

---

## 🎓 Conclusión
[cite_start]A través de este proyecto se logró dominar la creación de formularios simples en WinForms, la gestión de eventos de usuario y la implementación de seguridad básica mediante **Regex**[cite: 35].

---
[cite_start]**Desarrollado por:** Edwin Ivan Ramirez Gomez [cite: 1]  
[cite_start]**Institución:** Universidad de Guadalajara - CUCEI [cite: 1]
