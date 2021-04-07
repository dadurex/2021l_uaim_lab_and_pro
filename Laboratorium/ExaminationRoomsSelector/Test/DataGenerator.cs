﻿namespace ExaminationRoomsSelector.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Web.Application.Dtos;

    public class DataGenerator : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> DoctorNullRoomOne()
        {
            yield return new object[]
            {
                null,
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "69b", Certifications = new[] {1, 2, 4}}
                }
            };
        }

        public static IEnumerable<object[]> DoctorOneRoomNull()
        {
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Marcin", LastName = "Dadura", Specializations = new[] {1, 2, 3}},
                },
                null
            };
        }

        public static IEnumerable<object[]> DoctorOneRoomOne()
        {
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Marcin", LastName = "Dadura", Specializations = new[] {1, 2, 3}},
                },
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "69b", Certifications = new[] {1, 2, 4}}
                }
            };
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Maciej", LastName = "Włodarczyk", Specializations = new[] {3, 4, 5}},
                },
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1, 2, 5, 6}},
                }
            };
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Zbigniew", LastName = "Ktosowski", Specializations = new[] {1, 2, 5}},
                },
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "321a", Certifications = new[] {1, 2, 3, 4, 5, 6, 7}}
                }
            };
        }


        public static IEnumerable<object[]> DoctorManyRoomsMany()
        {
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Marcin", LastName = "Dadura", Specializations = new[] {1, 2, 3}},
                    new DoctorDto {FirstName = "Maciej", LastName = "Włodarczyk", Specializations = new[] {3, 4, 5}},
                    new DoctorDto {FirstName = "Zbigniew", LastName = "Ktosowski", Specializations = new[] {1, 2, 5}},
                    new DoctorDto {FirstName = "Krzysztof", LastName = "Walusiak", Specializations = new[] {6,7,8}}
                },
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "69b", Certifications = new[] {1, 6, 4}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1, 2, 5, 6}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {8, 8, 5, 6}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1, 2, 4, 6}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1, 123, 5, 6}},

                },
                4
            };
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Marcin", LastName = "Dadura", Specializations = new[] {1}},
                    new DoctorDto {FirstName = "Maciej", LastName = "Włodarczyk", Specializations = new[] {3}},
                    new DoctorDto {FirstName = "Zbigniew", LastName = "Ktosowski", Specializations = new[] {1}},
                    new DoctorDto {FirstName = "Krzysztof", LastName = "Walusiak", Specializations = new[] {6}}
                },
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "69b", Certifications = new[] {1}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {3}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1}},

                },
                3
            };
            yield return new object[]
            {
                new List<DoctorDto>()
                {
                    new DoctorDto {FirstName = "Marcin", LastName = "Dadura", Specializations = new[] {1, 2}},
                    new DoctorDto {FirstName = "Maciej", LastName = "Włodarczyk", Specializations = new[] {3, 4}},
                    new DoctorDto {FirstName = "Zbigniew", LastName = "Ktosowski", Specializations = new[] {1, 3}},
                    new DoctorDto {FirstName = "Krzysztof", LastName = "Walusiak", Specializations = new[] {2, 3}},
                    new DoctorDto {FirstName = "Krzysztof", LastName = "Walusiak", Specializations = new[] {6}}
                },
                new List<ExaminationRoomDto>()
                {
                    new ExaminationRoomDto {Number = "69b", Certifications = new[] {1, 3}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {1, 2}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {3, 1}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {6}},
                    new ExaminationRoomDto {Number = "112", Certifications = new[] {9}}
                },
                4
            };
        }


        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}