# Trabajo de equiparación Ing. de Software 2
## Introduccion
En el ámbito del desarrollo de software moderno, la adopción de prácticas de Integración Continua (CI or Continuous Integration), Entrega Continua (CD or Continuous Delivery) y Despliegue Continuo (CDD or Continuous Deployment Delivery) es fundamental para automatizar el ciclo de vida del desarrollo de software, garantizar la calidad del código y facilitar la entrega rápida de nuevas funcionalidades y correcciones a los usuarios finales. En este trabajo, me centré en la implementación de la práctica de Integración Continua (CI) utilizando .NET para crear un programa sencillo complementado con pruebas unitarias a través de la herramienta xUnit. Mediante GitHub Actions, configuré un pipeline de CI que compila el código, ejecuta pruebas unitarias y valida la integración del código con cada cambio subido al proyecto, siguiendo las mejores prácticas de CI.

La configuración actual de mi proyecto soporta la Integración Continua (CI), preparando automáticamente los cambios de código para su despliegue mediante la compilación del software y la ejecución de pruebas. Sin embargo, para avanzar hacia la Entrega Continua (CD) y el Despliegue Continuo (CDD), sería necesario implementar pasos adicionales:

- Para CD: Automatización del proceso de despliegue en un entorno de pruebas o producción mediante la integración de herramientas de despliegue que actúen en base a la aprobación manual o criterios específicos, garantizando que cada cambio validado esté listo para ser liberado en cualquier momento.

- Para CDD: Configuración de despliegues automáticos para que todo cambio que supere todas las etapas de validación en el pipeline se libere a los usuarios finales sin intervención manual, eliminando así la necesidad de una decisión de despliegue explícita y acelerando la entrega de valor a los clientes.

Este trabajo, por tanto, se enfoca en la exploración teórica de CI/CD y práctica de la Integración Continua (CI), demostrando cómo puede mejorar la calidad del software y optimizar el proceso de desarrollo. A continuación, se presentará el contenido teórico que respalda estas prácticas.
## Desarrollo del Tema
### CI/CD
En el pasado, el desarrollo de software era un proceso lento y manual. Los desarrolladores escribían código, lo probaban y luego lo implementaban en producción. Este proceso era propenso a errores y podía llevar mucho tiempo.
CI/CD (Integración y Entrega Continua) es una práctica moderna de desarrollo de software que automatiza y agiliza el proceso de desarrollo. CI/CD se basa en dos principios clave:
- Integración continua: Los desarrolladores integran sus cambios de código con frecuencia en un repositorio central.
- Entrega continua: Los cambios de código integrados se prueban y se implementan automáticamente en producción.

##### Desarrollo conceptual
CI/CD se compone de dos fases principales:

1. Integración continua (CI)
Automatización de la integración: Los cambios de código se integran automáticamente en un repositorio central.
Pruebas automatizadas: Se ejecutan pruebas automatizadas para verificar la calidad del código.
Detección temprana de errores: Los errores se detectan y se corrigen temprano en el proceso de desarrollo.

2. Entrega continua (CD)
Implementación automatizada: Los cambios de código probados se implementan automáticamente en producción.
Despliegue gradual: Los cambios de código se pueden implementar gradualmente a los usuarios finales.
Reversión rápida: Los cambios de código se pueden revertir rápidamente si hay algún problema.

##### Componentes clave de CI/CD
  * Servidor de integración continua: Automatiza la integración y las pruebas de código.
  * Repositorio de código: Almacena el código fuente de forma centralizada.
  * Herramientas de prueba: Automatizan las pruebas de unidad, integración y aceptación.
  * Herramientas de implementación: Automatizan la implementación de código en producción.

##### Beneficios de CI/CD
  * Mejora la calidad del software: La detección temprana de errores y las pruebas automatizadas ayudan a mejorar la calidad del software.
  * Acelera el tiempo de lanzamiento: Los cambios de código se pueden implementar en producción más rápido.
  * Reduce los costes: La automatización del proceso de desarrollo reduce los costes.
  * Mejora la colaboración: CI/CD facilita la colaboración entre los equipos de desarrollo y operaciones.

##### Aplicación práctica

Ejemplo:

Un equipo de desarrollo está trabajando en una aplicación web. Los desarrolladores utilizan un servidor de integración continua para automatizar la integración y las pruebas de código. Cada vez que un desarrollador realiza un cambio en el código, se activa el servidor de integración continua. El servidor de integración continua integra el código, ejecuta pruebas automatizadas y envía una notificación al equipo si hay algún problema.

Si las pruebas se ejecutan correctamente, el servidor de integración continua implementa automáticamente el código en un entorno de prueba. El equipo de pruebas puede probar la aplicación en el entorno de prueba antes de implementarla en producción.

Si la aplicación funciona correctamente en el entorno de prueba, el equipo de operaciones puede implementarla automáticamente en producción utilizando una herramienta de implementación.

##### Mejores prácticas y recomendaciones
* Comenzar con un proyecto pequeño: Es recomendable comenzar con un proyecto pequeño para familiarizarse con CI/CD.
* Automatizar todo lo que sea posible: Automatizar tantas tareas como sea posible para agilizar el proceso de desarrollo.
* Utilizar herramientas de código abierto: Hay muchas herramientas de código abierto disponibles para CI/CD.
* Implementar un entorno de prueba: Es importante tener un entorno de prueba para probar los cambios de código antes de implementarlos en producción.
* Monitorizar el proceso: Es importante monitorizar el proceso de CI/CD para identificar y solucionar problemas.

## Beneficios de implementar CI/CD
**En el área de desarrollo:**
* **Mejora la calidad del software:** La detección temprana de errores y las pruebas automatizadas ayudan a mejorar la calidad del software.
* **Acelera el tiempo de lanzamiento:** Los cambios de código se pueden implementar en producción más rápido.
* **Reduce los costes:** La automatización del proceso de desarrollo reduce los costes.
* **Mejora la colaboración:** CI/CD facilita la colaboración entre los equipos de desarrollo y operaciones.

**En otras áreas:**
* **Mejora la satisfacción del cliente:** Los clientes obtienen acceso a nuevas funciones y correcciones de errores más rápido.
* **Aumenta la competitividad:** Las empresas que implementan CI/CD pueden lanzar productos al mercado más rápido que sus competidores.
* **Reduce el riesgo de errores:** La automatización del proceso de desarrollo reduce el riesgo de errores humanos.

## Desafíos y consideraciones
**Desafíos:**

* **Cambio cultural:** Implementar CI/CD requiere un cambio cultural en la organización.
* **Costo de herramientas:** Las herramientas de CI/CD pueden ser costosas.
* **Integración con sistemas existentes:** La integración de CI/CD con sistemas existentes puede ser un desafío.

**Consideraciones:**

* **Elegir las herramientas adecuadas:** Es importante elegir las herramientas de CI/CD adecuadas para las necesidades de la organización.
* **Capacitar al personal:** Es importante capacitar al personal en el uso de las herramientas de CI/CD.
* **Definir un proceso claro:** Es importante definir un proceso claro para el desarrollo e implementación de software.

## Desafíos de Seguridad al Implementar CI/CD
La implementación de CI/CD presenta desafíos de seguridad significativos, resaltados en el "Top 10 CI/CD Security Risks" de OWASP (The Open Worldwide Application Security Project). Cada uno de estos riesgos demanda atención cuidadosa para fortalecer las prácticas de seguridad en los pipelines de CI/CD.

* Mecanismos de Control de Flujo Insuficientes (CICD-SEC-1): La ausencia de controles adecuados puede permitir que un atacante propague código o artefactos maliciosos sin revisión adicional o aprobación.

* Gestión de Identidad y Acceso Inadecuada (CICD-SEC-2): La gestión inadecuada de identidades incrementa el riesgo y el potencial daño de un compromiso, debido a la complejidad y diversidad de los sistemas involucrados en el proceso de entrega de software.

* Abuso de la Cadena de Dependencias (CICD-SEC-3): Atacantes pueden explotar la cadena de dependencias para ejecutar paquetes maliciosos, afectando las estaciones de trabajo de ingeniería y los entornos de construcción.

* Ejecución de Pipeline Envenenada (PPE) (CICD-SEC-4): Atacantes pueden manipular el proceso de construcción, inyectando comandos maliciosos en la configuración del pipeline.

* Controles de Acceso Basados en Pipeline Insuficientes (CICD-SEC-5): La ejecución de pipelines sin controles de acceso adecuados facilita el movimiento lateral de atacantes dentro o fuera del sistema CI/CD.

* Higiene Insuficiente de Credenciales (CICD-SEC-6): La diversidad de sistemas y la complejidad en la gestión de accesos exige una estrategia robusta que asegure el principio de mínimo privilegio y la rotación regular de secretos.

* Configuración Insegura del Sistema (CICD-SEC-7): Es crucial aplicar configuraciones seguras, parchear vulnerabilidades conocidas y emplear técnicas de endurecimiento para proteger los sistemas del entorno CI/CD.

* Uso No Gobernado de Servicios de Terceros (CICD-SEC-8): La integración sin supervisión de servicios de terceros puede ampliar la superficie de ataque, introduciendo riesgos no anticipados.

* Validación Inadecuada de la Integridad de los Artefactos (CICD-SEC-9): La implementación de firmas digitales, checksums y otros controles de integridad es esencial para asegurar que solo los artefactos auténticos avancen hacia la producción.

* Insuficiente Registro y Visibilidad (CICD-SEC-10): La falta de un registro y monitoreo adecuados impide la detección oportuna de actividades maliciosas y complica las investigaciones de incidentes.

## Conclusión

CI/CD es una práctica moderna de desarrollo de software que ofrece muchos beneficios. Es importante tener en cuenta los desafíos y las consideraciones al implementar CI/CD, pero los beneficios pueden ser significativos. CI/CD es una herramienta importante para las empresas que quieren mejorar la calidad del software, acelerar el tiempo de lanzamiento y aumentar la competitividad.

## Referencias

* "A Brief History of Software Development" por Michael Lopp
* "Continuous Integration and Continuous Delivery" por Martin Fowler
* "The CI/CD Handbook" por Jez Humble y David Farley
* "CI/CD Recommendations" por Google Cloud
* "CI/CD Example" por Atlassian
* "The Benefits of CI/CD" por Atlassian
* "The Future of CI/CD" por Atlassian
* "The Challenges of CI/CD" por Atlassian
* "Continuous integration vs. delivery vs. deployment" por Atlassian
* "How to Implement CI/CD" por Microsoft
* "Why You Should Implement CI/CD" por Microsoft
* "How to Overcome the Challenges of CI/CD" por Microsoft
* "The Importance of CI/CD in Software Engineering" por Microsoft
* "OWASP Top 10 CI/CD Security Risks" por OWASP






