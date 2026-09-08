; Shipped analyzer releases
; https://github.com/dotnet/roslyn-analyzers/blob/main/src/Microsoft.CodeAnalysis.Analyzers/ReleaseTrackingAnalyzers.Help.md

## Release 1.0.0

### New Rules

Rule ID | Category | Severity | Notes
--------|----------|----------|------------------------------------------------------------------
NE0001  | MinimalEndpoints | Warning | Endpoint declares no route
NE0002  | MinimalEndpoints | Warning | Contract parameter type cannot be bound
NE0003  | MinimalEndpoints | Warning | Configure reads constructor-injected state
NE0004  | MinimalEndpoints | Warning | Contract has more than one public constructor
NE0005  | MinimalEndpoints | Warning | Endpoint derives from ApiEndpointBase directly
NE0006  | MinimalEndpoints | Warning | Contract binds a form on a method with no request body
