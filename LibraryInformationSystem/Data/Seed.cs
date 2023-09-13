using LibraryInformationSystem.Models;
using System.Security.Cryptography.Xml;

namespace LibraryInformationSystem.Data
{
    public class Seed
    {
        private readonly DataContext context; 
        public Seed(DataContext dataContext)
        {
            this.context = dataContext; 
        }

        public void SeedDataContext()
        {
            if(!context.BookCategories.Any())
            {
                var bookCategory = new BookCategory
                {
                    Book = new Book
                    {
                        Title = "История о золушке",

                        Description = "Сказка Шарля Перро «Золушка» живёт на свете не одно столетие. Она не устаревает и продолжает завоёвывать любовь маленьких читателей. Многие художники рисовали «Золушку», но образ доброй прекрасной принцессы, которые воплотили в великолепных иллюстрациях известные во всём мире художники Эрик Булатов и Олег Васильев, стал классическим. Стоит раз увидеть их Золушку, как сразу понимаешь, что она была именно такой.\r\n\r\nДля детей до 3-х лет.",
                        DateOfPublished = new DateTime(1697),
                        DateOfCreated = DateTime.Now,
                        DateOfModified = DateTime.Now,
                        Language = "Русский",
                        Price = 15,
                        PageCount = 65,
                        CreatedBy = new User
                        {
                            FirstName = "Шерова",
                            LastName = "Нилуфар",
                            MiddleName = "Умеджоновна",
                            DateOfBirth = new DateTime(2000, 07, 08),
                            DateOfRegister = DateTime.Now,
                            Type = 'S',
                            Email = "nellysherova@mail.ru",
                            Phone = "+992909929763",
                            Nickname = "Nelly",
                            Password = "123456789",
                            Role = new Role
                            {
                                Name = "SuperAdmin",
                                Description = "Главный пользователь системы"
                            },
                            Faculty = new Faculty
                            {
                                Name = "Естественно - научный",
                                Directions = new List<Direction>
                                {
                                    new Direction
                                    {
                                        Name = "Прикладная математика и информатика"
                                    },
                                    new Direction
                                    {
                                        Name = "Химия, физика и механика материалов"
                                    },
                                    new Direction
                                    {
                                        Name = "Геология"
                                    }
                                }
                            }


                        },
                        Files = new List<Files>
                        {
                            new Files
                            {
                                Name = "Photo",
                                Path = "dsfsdfsdf/dsfsdf"
                            }
                        },
                        BookAuthors = new List<BookAuthor>
                        {
                            new BookAuthor
                            {
                                Author = new Author
                                {
                                    FullName = "Шарль Перро",
                                    About = "Шарль Перро (1628—1703) известен всему миру как сказочник. «Золушка», «Кот в сапогах», «Красная Шапочка» и т. д., список, известных с детства сказок, можно продолжать и продолжать. Первый сборник сказок Шарля Перро был опубликован в 1697 году и назывался «Сказки матушки гусыни, или Истории и сказки былых времен с поучениями». Шарль Перро собирал народные сказки для того, чтобы уберечь их от исчезновения. Член Французской академии с 1671.\r\nПодробнее: https://www.labirint.ru/authors/15734/"
                                }
                            }
                        },
                        BookGenres = new List<BookGenre>
                        {
                            new BookGenre
                            {
                                Genre = new Genre
                                {
                                    Name = "Сказка"
                                }
                            },
                            new BookGenre
                            {
                                Genre = new Genre
                                {
                                    Name = "Для детей"
                                }
                            }
                        }
                    },
                    Category = new Category
                    {
                        Name = "Классика"
                    }
                };
                context.BookCategories.AddRange(bookCategory);
                context.SaveChanges();
            }
        }
    }
}
