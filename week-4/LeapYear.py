from unittest import TestCase

# YearHelper class is redacted as it's not my code.

class TestLeapYear(TestCase):
    ft = YearHelper()
    # example code
    # def test_year1(self):
    #   self.assertEqual(False, self.ft.leap_year(_year_))

    # Your code starts after this line
    def test_year1(self):
        with self.assertRaises(ValueError):
            self.ft.leap_year(1581)

    def test_year2(self):
        self.assertEqual(self.ft.leap_year(1582), False)

    def test_year3(self):
        self.assertEqual(self.ft.leap_year(1584), True)

    def test_year4(self):
        self.assertEqual(self.ft.leap_year(1600), True)

    def test_year5(self):
        self.assertEqual(self.ft.leap_year(1700), False)
    # Your code ends before this line
