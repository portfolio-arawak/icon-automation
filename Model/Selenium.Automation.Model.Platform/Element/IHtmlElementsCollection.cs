using System.Collections.Generic;

namespace Selenium.Automation.Model.Platform.Element
{
	public interface IHtmlElementsCollection<out THtmlElement> : IEnumerable<THtmlElement>
		where THtmlElement : IHtmlElement
	{
	}
}
