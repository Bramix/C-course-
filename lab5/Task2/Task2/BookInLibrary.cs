namespace Task2
{
    public class BookInLibrary
    {
        private string fio;
        private string name;
        private string code;
        private int yearOfPublishing;
        private int countOfPages;
        private string genre;

        public BookInLibrary() {}

        public BookInLibrary(string fio, string name, string code, int yearOfPublishing, int countOfPages, string genre)
        {
            this.fio = fio;
            this.name = name;
            this.code = code;
            this.yearOfPublishing = yearOfPublishing;
            this.countOfPages = countOfPages;
            this.genre = genre;
        }
        
        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Fio => fio;

        public string Name => name;

        public int YearOfPublishing => yearOfPublishing;

        public int CountOfPages => countOfPages;

        public string Genre => genre;

        bool EqualsByFio(BookInLibrary bookInLibrary)
        {
            return this.fio.Equals(bookInLibrary.fio);
        }
        bool EqualsByCode(BookInLibrary bookInLibrary)
        {
            return this.Code.Equals(bookInLibrary.Code);
        }
        bool EqualsByName(BookInLibrary bookInLibrary)
        {
            return this.Name.Equals(bookInLibrary.Code);
        }
        bool EqualsByYearOfPublishing(BookInLibrary bookInLibrary)
        {
            return this.YearOfPublishing.Equals(bookInLibrary.YearOfPublishing);
        }
        bool EqualsByCountOfPages(BookInLibrary bookInLibrary)
        {
            return this.CountOfPages.Equals(bookInLibrary.CountOfPages);
        }
        bool EqualsByGenre(BookInLibrary bookInLibrary)
        {
            return this.Genre.Equals(bookInLibrary.Genre);
        }

        public override string ToString()
        {
            return $"{nameof(fio)}: {fio}, {nameof(name)}: {name}, {nameof(code)}: {code}, {nameof(yearOfPublishing)}: {yearOfPublishing}, {nameof(countOfPages)}: {countOfPages}, {nameof(genre)}: {genre}";
        }
    }
}