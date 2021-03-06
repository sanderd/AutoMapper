namespace AutoMapper.QueryableExtensions
{
    public interface IExpressionResultConverter
    {
        ExpressionResolutionResult GetExpressionResolutionResult(ExpressionResolutionResult expressionResolutionResult, PropertyMap propertyMap, LetPropertyMaps letPropertyMaps);
        ExpressionResolutionResult GetExpressionResolutionResult(ExpressionResolutionResult expressionResolutionResult, ConstructorParameterMap propertyMap);
        bool CanGetExpressionResolutionResult(ExpressionResolutionResult expressionResolutionResult, PropertyMap propertyMap);
        bool CanGetExpressionResolutionResult(ExpressionResolutionResult expressionResolutionResult, ConstructorParameterMap propertyMap);
    }
}