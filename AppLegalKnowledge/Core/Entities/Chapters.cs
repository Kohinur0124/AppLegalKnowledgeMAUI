namespace LegalKnowledge.Domain.Entities

{

	public class Chapters
	{

		public int Id { get; set; }

		public int Number { get; set; }

		public string Title { get; set; }

		public int DepartmentsId { get; set; }
	}
}
