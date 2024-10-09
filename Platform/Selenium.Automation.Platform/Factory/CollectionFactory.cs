using System;

using Selenium.Automation.Model.Platform.Element;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.Factory
{
	internal static class CollectionFactory
	{
		internal static IHtmlElementsCollection<THtmlElement> Create<THtmlElement>(
			INative parent,
			Locator locator)
			where THtmlElement : IHtmlElement, new() =>
				new HtmlElementsCollection<THtmlElement>(parent, locator);

		internal static object Create(Type type, INative parent, Locator locator)
		{
			var concreteType = typeof(HtmlElementsCollection<>)
				.MakeGenericType(type.GetGenericArguments());
			return Activator.CreateInstance(concreteType, parent, locator);
		}
	}
}
