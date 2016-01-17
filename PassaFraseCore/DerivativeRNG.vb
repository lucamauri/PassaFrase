
Imports System.Security.Cryptography
'''<summary>
''' Represents a pseudo-random number generator, a device that produces random data.
'''</summary>
Class DerivativeRNG
    Inherits RandomNumberGenerator
    Private Shared r As RandomNumberGenerator
    '''<summary>
    ''' Creates an instance of the default implementation of a cryptographic random number generator that can be used to generate random data.
    '''</summary>
    Public Sub New()
        r = RandomNumberGenerator.Create()
    End Sub
    '''<summary>
    ''' Fills the elements of a specified array of bytes with random numbers.
    '''</summary>
    '''<param name="buffer">An array of bytes to contain random numbers.</param>
    Public Overrides Sub GetBytes(buffer As Byte())
        r.GetBytes(buffer)
    End Sub
    '''<summary>
    ''' Returns a random number between 0.0 and 1.0.
    '''</summary>
    Public Function NextDouble() As Double
        Dim b As Byte() = New Byte(3) {}
        r.GetBytes(b)
        Return CDbl(BitConverter.ToUInt32(b, 0)) / UInt32.MaxValue
    End Function
    '''<summary>
    ''' Returns a random number within the specified range.
    '''</summary>
    '''<param name="maxValue">The inclusive lower bound of the random number returned.</param>
    '''<param name="minValue">The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
    Public Function [Next](minValue As Integer, maxValue As Integer) As Integer
        Return CInt(Math.Round(NextDouble() * (maxValue - minValue - 1))) + minValue
    End Function
    '''<summary>
    ''' Returns a nonnegative random number.
    '''</summary>
    Public Function [Next]() As Integer
        Return [Next](0, Int32.MaxValue)
    End Function
    '''<summary>
    ''' Returns a nonnegative random number less than the specified maximum
    '''</summary>
    '''<param name="maxValue">The inclusive upper bound of the random number returned. maxValue must be greater than or equal 0</param>
    Public Function [Next](maxValue As Integer) As Integer
        Return [Next](0, maxValue)
    End Function
End Class