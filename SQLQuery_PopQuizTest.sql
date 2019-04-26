DECLARE @number INT
SET @number = 1
WHILE @number <= 100
BEGIN 
	IF( @number % 7 = 0 AND @number % 9 = 0 )
	  PRINT 'PopQuiz'
	ELSE IF ( @number % 7 = 0 )
	  PRINT 'Pop'
	ELSE IF ( @number % 9 = 0 )
	  PRINT 'Quiz'
	ELSE PRINT @number

    IF @number > 100
        BREAK
	SET @number = @number + 1
END