public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
		var buffer = new byte[9];
		var bytes = BitConverter.GetBytes(reading);
		buffer[0] = reading switch
		{
			>= int.MinValue and < short.MinValue => 256 - 4,
			>= short.MinValue and < 0 => 256 - 2,
			>= 0 and <= ushort.MaxValue => 2,
			> ushort.MaxValue and <= int.MaxValue => 256 - 4,
			> int.MinValue and <= uint.MaxValue => 4,
			_ => 256 - 8
		};
		int prefix = Math.Abs((buffer[0] < 8) ? buffer[0] : buffer[0] - 256);
		Array.Copy(bytes, 0, buffer, 1, prefix);
		return buffer;
	}
	public static long FromBuffer(byte[] buffer)
	{
		int firstOne = buffer[0];
		switch (firstOne)
		{
			case (256 - 8): return BitConverter.ToInt64(buffer, 1);
			case (256 - 4): return BitConverter.ToInt32(buffer, 1);
			case (256 - 2): return BitConverter.ToInt16(buffer, 1);
			case 002: return BitConverter.ToUInt16(buffer, 1);
			case 004: return BitConverter.ToUInt32(buffer, 1);
			default: return 0;
		}
	}
}
