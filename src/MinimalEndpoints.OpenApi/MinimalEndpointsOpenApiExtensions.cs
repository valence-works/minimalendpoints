using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.DependencyInjection;

namespace MinimalEndpoints.OpenApi;

/// <summary>Registers the MinimalEndpoints OpenAPI integration.</summary>
public static class MinimalEndpointsOpenApiExtensions
{
    /// <summary>
    /// Documents the parameters MinimalEndpoints operations bind, and the form fields they accept.
    /// Call alongside <c>AddOpenApi</c>.
    /// </summary>
    public static IServiceCollection AddMinimalEndpointsOpenApi(this IServiceCollection services, string documentName = "v1")
    {
        ArgumentNullException.ThrowIfNull(services);
        return services.Configure<OpenApiOptions>(documentName, options =>
        {
            options.AddOperationTransformer<EndpointParameterTransformer>();
            options.AddOperationTransformer<EndpointFormRequestBodyTransformer>();
        });
    }
}
