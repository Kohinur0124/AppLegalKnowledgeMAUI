namespace LegalKnowledge.Domain.Entities
{

	public class Departments
	{
		public int Id { get; set; }
		public int DepartmentNumber { get; set; }

		public string Title { get; set; }

		public int DocumentsId { get; set; }

	}
}
