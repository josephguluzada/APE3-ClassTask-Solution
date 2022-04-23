# APE3-ClassTask-Solution

# Task 1:

============
Room class
============
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Price
- PersonCapacity - otağın neçə nəfərlik olduğunu bildirir.
- IsAvailable - otağın rezervasiya olunub olunmadığını göstərir (true/false), default olaraq true olmalıdır.
- ShowInfo() - Otağın bütün məlumatlarını göstərir

ToString methodunu override edirsiz və geriyə ShowInfo methodunu qaytarırsız.
ps: Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz
============
Hotel class
============
- Name
- Rooms array - içində Room obyektləri saxlayır və private-dır.
- AddRoom() - Parametr olaraq Room obyekti qəbul edib rooms arrayinə əlavə edir.
- MakeReservation() - Parametr olaraq int tipindən bir roomId qəbul edir ve verilen roomId-li otaq tapılır,
IsAvailable dəyəri yoxlanılır əgər IsAvailable dəyəri  false-dusa "Room is Full!" yazdirsin,
əgər true-dursa həmin room-un IsAvailable dəyəri false olur.

ps: Name dəyəri olmadan bir Hotel obyekti yaratmaq olmaz.
============
Program class:
============
1. İki ədəd room obyekti yaradırsız daha sonra bir hotel obyekti yaradırsız hotel obyektinin içindəki AddRoom methodu
vasitəsilə yaratdığınız iki room obyektini hoteldəki rooms arrayinə əlavə edirsiz.
2. GetRooms() - methodu ilə private arrayin içərisindəki otaqları göstərmək
3. MakeReservation() - yoxlamaq.

# Task 2:

String'in ilk hərfini Böyüdən extension method yazın - Capitalize methodu