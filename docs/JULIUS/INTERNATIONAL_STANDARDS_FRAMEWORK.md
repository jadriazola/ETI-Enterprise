# JULIUS International Standards Framework

## Política transversal obligatoria
El marco de estándares y cumplimiento es una capacidad transversal de JULIUS. Aplica a JULIUS Core, cada módulo interno, cada subsistema, cada producto de System Factory y todos los ecosistemas externos que JULIUS administre, integre, supervise o ayude a desarrollar.

Esta política también debe incorporarse a las plantillas, agentes, flujos de trabajo, APIs, conectores, automatizaciones, interfaces, datos, infraestructura, documentación y procesos de operación.

## Principio de aplicación contextual
La cobertura es universal; la norma concreta es contextual. No se impondrá una norma que no corresponda al alcance, sector, riesgo o naturaleza del sistema. Cada subsistema mantendrá una matriz de aplicabilidad que documente:
- Norma, estándar, marco o regulación y su versión vigente.
- Alcance, procesos, activos y componentes a los que aplica.
- Justificación de aplicabilidad, exclusión o adaptación.
- Requisitos y controles pertinentes.
- Responsable, evidencia requerida, indicador y frecuencia de revisión.
- Brechas, riesgos, acciones correctivas y estado de cumplimiento.
- Restricciones de licencia, propiedad intelectual y acceso a textos normativos.

## Capas del marco
1. Gobernanza y dirección: PMI, ISO 21502 y prácticas de portafolio, programa y proyecto.
2. Calidad y mejora: ISO 9001, ISO 10006 y métodos de aseguramiento y control.
3. Riesgos, continuidad y resiliencia: ISO 31000, ISO 22301 y controles relacionados.
4. Seguridad, privacidad y datos: ISO/IEC 27001, ISO/IEC 27701 cuando corresponda, y legislación aplicable.
5. Inteligencia artificial: ISO/IEC 42001, gestión de riesgos de IA y evaluaciones de modelos.
6. Software y tecnología: ISO/IEC/IEEE 12207, ISO/IEC 25010, prácticas DevSecOps y estándares de arquitectura pertinentes.
7. Servicios y operaciones: ISO/IEC 20000-1, gestión de configuración, incidentes, cambios y niveles de servicio.
8. Ingeniería y sectores especializados: normas técnicas, códigos, reglamentos y requisitos contractuales específicos de cada disciplina y jurisdicción.
9. Gestión ambiental y sostenibilidad: ISO 14001, ISO 50001 u otros marcos cuando el alcance lo requiera.
10. Cumplimiento y auditoría: obligaciones legales, regulatorias, contractuales, controles internos y trazabilidad de evidencias.

Esta lista es una taxonomía inicial, no una declaración de que todas las normas sean aplicables o estén implementadas. Antes de usarlas en producción, JULIUS verificará título, edición, vigencia, enmiendas, jurisdicción y licencia en fuentes oficiales.

## Motor transversal
El Standards & Compliance Engine debe ofrecer un registro versionado de normas y controles, motor de aplicabilidad, matriz de correspondencia, catálogo de evidencias, evaluación de brechas, gestión de excepciones, planes de tratamiento, auditoría y reportes de cumplimiento.

## Integración con todos los subsistemas
- Cada subsistema declara su contexto, criticidad, datos tratados, interfaces, obligaciones y normas aplicables.
- JULIUS Core establece políticas mínimas comunes de seguridad, trazabilidad, gestión de cambios, calidad y control de acceso.
- Los subsistemas agregan controles especializados sin duplicar ni contradecir las políticas globales.
- Los ecosistemas externos se evalúan antes de integrarse y se supervisan durante su ciclo de vida.
- System Factory genera desde el inicio una matriz de cumplimiento y pruebas de aceptación para cada sistema nuevo.
- Los agentes de IA consultan controles y restricciones antes de ejecutar tareas y registran evidencia de sus decisiones.

## Jerarquía y resolución de conflictos
Se respetará la legislación y regulación obligatoria de la jurisdicción, los contratos y requisitos del cliente, los estándares técnicos aplicables y las políticas internas aprobadas. Si hay conflicto, JULIUS lo registra, explica el impacto y escala la decisión; nunca resuelve silenciosamente una obligación legal o contractual.

## Reglas de integridad
- No afirmar certificación, conformidad ni cumplimiento sin auditoría y evidencia suficiente.
- Distinguir requisitos obligatorios, recomendaciones, buenas prácticas y controles internos.
- No copiar ni redistribuir textos protegidos de normas; almacenar metadatos, referencias y evidencias permitidas.
- Mantener versiones y fechas de vigencia para evitar aplicar ediciones obsoletas.
- Las excepciones deben tener justificación, propietario, aprobación, vencimiento y controles compensatorios.
- Revisar el marco ante cambios normativos, incidentes, cambios de arquitectura y revisiones periódicas.

## Criterio de aceptación global
Ningún subsistema o ecosistema se considerará listo para producción sin una evaluación documentada de aplicabilidad, riesgos, seguridad, calidad, obligaciones legales y controles pertinentes. La profundidad de evaluación será proporcional a su criticidad, exposición y consecuencias de fallo.