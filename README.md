# Examen Unidad 2: Patrones de Software

Este repositorio contiene la solución para el examen de la segunda unidad del curso de Patrones de Software. El proyecto demuestra la implementación del patrón de diseño **Facade** en una aplicación de consola .NET 9, junto con la configuración de un pipeline de Integración Continua y Despliegue Continuo (CI/CD) utilizando **GitHub Actions**.

| Característica | Descripción |
| :--- | :--- |
| **Curso** | Patrones de Software |
| **Universidad** | Universidad Privada de Tacna (UPT) |
| **Facultad** | FAING - EPIS |
| **Estudiante** | Jorge Luis Briceño Diaz|
| **Tecnología** | .NET 9, C#, xUnit |

---

## 🚀 Resultados de la Automatización

*   **📘 Documentación Publicada:** [**Ver Documentación en GitHub Pages**](https://upt-faing-epis.github.io/examen-si889-2025-ii-u2-J0rgZ/)
*   **⚙️ Ejecución de Workflows:** [**Ver Historial de Actions**](https://github.com/UPT-FAING-EPIS/examen-si889-2025-ii-u2-J0rgZ/actions)

---

## 🎯 Objetivos del Proyecto

El proyecto cumple con los siguientes requisitos del examen:

1.  **Refactorización con Patrón Facade:** Se refactorizó un sistema complejo de procesamiento de órdenes para simplificar su uso a través de una fachada (`OrderFacade`).
2.  **Pruebas Unitarias:** Se implementaron pruebas unitarias con xUnit para validar el comportamiento del `OrderFacade`.
3.  **Automatización de CI/CD con GitHub Actions:**
    *   **Workflow de Versión (`publish_version.yml`):** Compila el código, ejecuta las pruebas y crea un *release* en GitHub automáticamente cuando se crea un tag de versión (ej. `v1.0.0`).
    *   **Workflow de Documentación (`publish_doc.yml`):** Genera y publica una página de documentación simple en GitHub Pages cada vez que se actualiza la rama `main`.

## 📂 Estructura del Proyecto

El repositorio está organizado de la siguiente manera para separar claramente la aplicación de las pruebas y la configuración de CI/CD.

.
├── .github/
│ └── workflows/
│ ├── publish_doc.yml # Workflow para la documentación
│ └── publish_version.yml # Workflow para compilar, probar y crear releases
├── src/
│ └── MiAplicacion/ # Proyecto principal de la aplicación
│ ├── OrderFacade.cs
│ ├── InventoryService.cs
│ ├── PaymentService.cs
│ └── ShippingService.cs
├── tests/
│ └── MiAplicacion.Tests/ # Proyecto de pruebas unitarias
│ └── OrderFacadeTests.cs
├── .gitignore
├── MiSolucion.sln
└── README.md

## 🛠️ Patrón Facade Implementado

El patrón de diseño estructural **Facade** se utilizó para proporcionar una interfaz simplificada a un subsistema complejo de procesamiento de órdenes.

-   **El Problema:** Un cliente que quería procesar una orden necesitaba interactuar directamente con tres servicios diferentes: `InventoryService`, `PaymentService` y `ShippingService`. Esto acoplaba fuertemente al cliente con la lógica interna del subsistema.
-   **La Solución:** Se introdujo la clase `OrderFacade`. Esta clase encapsula la complejidad de coordinar los tres servicios. Ahora, el cliente solo necesita llamar a un único método (`PlaceOrder`) en el `OrderFacade`, simplificando drásticamente el proceso y desacoplando el código.

## ⚙️ Automatización (GitHub Actions)

### 1. `publish_version.yml`
Este workflow se encarga de la integración continua y la publicación de nuevas versiones.

-   **Trigger:** Se activa automáticamente al crear y subir un tag a GitHub que siga el patrón `v*.*.*` (ej. `git tag v1.0.1 && git push origin v1.0.1`).
-   **Pasos:**
    1.  **Checkout:** Descarga el código del repositorio.
    2.  **Setup .NET 9:** Configura el entorno de ejecución con la versión correcta de .NET.
    3.  **Build:** Compila la aplicación en modo `Release`.
    4.  **Test:** Ejecuta todas las pruebas unitarias del proyecto.
    5.  **Create Release:** Si los pasos anteriores tienen éxito, crea un nuevo *Release* en la sección de "Releases" de GitHub, usando el nombre del tag.

### 2. `publish_doc.yml`
Este workflow se encarga de la generación y el despliegue de la documentación del proyecto.

-   **Trigger:** Se activa automáticamente con cada `push` a la rama `main`.
-   **Pasos:**
    1.  **Checkout:** Descarga el código del repositorio.
    2.  **Generate Docs:** Crea un archivo `index.html` simple y un diagrama SVG como *placeholders* para la documentación.
    3.  **Deploy to GitHub Pages:** Sube los archivos generados a una rama especial (`gh-pages`), desde la cual GitHub sirve el sitio web estático.