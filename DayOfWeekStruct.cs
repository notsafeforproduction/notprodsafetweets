public struct Fields
{
    public static ID Monday = new ID("{5A6A5CDD-D936-405A-8C3A-FDC313C80499}");
    public static ID Tuesday = new ID("{342F6370-85AD-4618-BE5E-6DE383B38063}");
    public static ID Wednesday = new ID("{238576E1-9694-4475-81E1-E648BB0451BF}");
    public static ID Thursday = new ID("{F636817A-B188-4485-A3A8-19690D79CBD3}");
    public static ID Friday = new ID("{54194AB8-71AE-4543-B18E-D0D6AFDD4A39}");
    public static ID Saturday = new ID("{43DB1FED-4129-4054-B92D-2CB2352210A7}");
    public static ID Sunday = new ID("{EB519BE8-C0F1-477F-89E4-0FC1B0694B0F}");

    public ID FieldFromDayOfWeek(DayOfWeek dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case DayOfWeek.Sunday:
                return Sunday;
            case DayOfWeek.Monday:
                return Monday;
            case DayOfWeek.Tuesday:
                return Tuesday;
            case DayOfWeek.Wednesday:
                return Wednesday;
            case DayOfWeek.Thursday:
                return Thursday;
            case DayOfWeek.Friday:
                return Friday;
            case DayOfWeek.Saturday:
                return Saturday;
        }

        return ID.Null;
    }
}