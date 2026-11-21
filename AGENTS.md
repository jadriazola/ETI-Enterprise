# Engineering Rules for JULIUS and ETI-Enterprise

## Preserve existing value
- Treat every change as a proposed improvement, not as an improvement by default.
- Preserve existing working behavior, public contracts, data integrity, security controls, and user workflows unless an approved requirement explicitly changes them.
- Do not rewrite, replace, rename, or restructure working components without evidence that the change is necessary and safer than a smaller alternative.
- Prefer minimal, modular, reversible changes over broad rewrites and unnecessary dependencies.

## Prove net improvement
- State the problem, baseline, expected benefit, affected components, risks, and measurable acceptance criteria before implementation.
- Evaluate alternatives, including making no change. Avoid adding features or process overhead without demonstrated value.
- Run relevant unit, integration, regression, security, compatibility, and performance tests; report exactly which tests ran and which did not.
- Compare observed results with the baseline. A change that causes a critical regression, weakens security, corrupts data, or increases operational burden without compensating value must not be accepted.
- Use staged rollout, feature flags, backups, monitoring, and rollback plans in proportion to change risk.
- Require independent review and explicit approval for high-impact production changes, destructive operations, permission changes, sensitive data handling, and external commitments.
- Update architecture records, documentation, operational procedures, and tests in the same change.

## Cross-system impact
- Before changing a shared component, map its consumers across all JULIUS subsystems and connected ecosystems.
- Maintain backward compatibility for APIs, events, schemas, files, and integrations, or provide a versioned migration path.
- Never assume a repository contains the whole system; document external dependencies and integration boundaries.
- Keep JULIUS bounded contexts separate from ETI business/domain code unless an explicit architecture decision authorizes integration.

## Standards and evidence
- Apply the JULIUS International Standards Framework with contextual applicability; do not claim certification or compliance without evidence.
- Record decisions, test evidence, risks, exceptions, owners, and rollback instructions.
- Verify current standard editions and legal obligations from authoritative sources before relying on them.

## Repository safety
- Work only on the explicitly authorized branch; do not modify `main`, merge, publish releases, or change production without authorization.
- Inspect the current implementation and repository guidance before editing.
- Do not report a file, commit, test, deployment, or integration as complete unless its result has been verified.