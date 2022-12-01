# DoggieNote

**- Encje -**

Competition - CompetitionId, Name, Place, List<Course>
  
Course - CoursId, Name, CompetitionId

  
**- Relacje -**
  
1 do wiele - 1 Competition wiele Course

**- Oczekiwania -**
  
Przy wyświetlaniu [Competition] -> [Details], wyświetlane wszystkie przypisane Courses.
  
Przy wprowadzaniu Course możliwość wyboru Competition z rozwijanej listy. (Listę można rozwinąć. Pojawiają się na niej Competition, ale nie można tego zapisać.)

  
**- Problem -**
  
Przy wyborze [Competition WITH relations] -> [Details] - pojawia się błąd: "Object reference not set to an instance of an object" w [Views]/[CompetitionControllerWithRelations]/[Details.cshtml] linijka 28

  
**- Uwagi -**
  
We wszystkich przykładach, które widziałam dodanie virtual do encji wystarczyło, aby działało. https://www.youtube.com/watch?v=g25ap6i8VH0 <- w 5 minut zrobił bez zwytniego wysiłku dodając tylko virtual
https://www.youtube.com/watch?v=VCTWqRGd8ms&t=1182s <- też tylko dodają virtual

A u mnie nie działa
