ALTER TABLE clients
ADD COLUMN `INN` DECIMAL(12) UNSIGNED NULL AFTER `Comments`,
ADD UNIQUE INDEX `INN_UNIQUE` (`INN` ASC) VISIBLE;

CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`dev1`@`localhost` SQL SECURITY DEFINER VIEW `clients_info` AS select `sales_infocl`.`Клиент` AS `Клиент`,`clients`.`Tel` AS `Телефон`,`sales_infocl`.`sm` AS `Заказов на`,`clients`.`Money` AS `На Счету`,`clients`.`Credit` AS `Ост. кредита`,`clients`.`Dolg` AS `Долг`,(`clients`.`Credit` + `clients`.`Dolg`) AS `Весь кредит`,`clients`.`Comments` AS `Комментарий`, CONCAT(ifnull(`clients`.`INN`,"!!! Отсутствует"),if(length(`clients`.`INN`)<12," ! короткий","")) as 'ИНН'  from (`clients` join `sales_infocl`) where (`sales_infocl`.`Клиент` = `clients`.`Client`);

