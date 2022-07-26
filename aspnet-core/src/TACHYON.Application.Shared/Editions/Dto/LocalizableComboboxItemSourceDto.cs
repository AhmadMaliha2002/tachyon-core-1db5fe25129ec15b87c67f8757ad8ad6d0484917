using System.Collections.ObjectModel;

namespace TACHYON.Editions.Dto
{
	//Mapped in CustomDtoMapper
	public class LocalizableComboboxItemSourceDto
	{
		public Collection<LocalizableComboboxItemDto> Items { get; set; }
	}
}