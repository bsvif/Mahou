[![GitHub release](https://img.shields.io/github/release/BladeMight/Mahou.svg?style=flat-square)](https://github.com/BladeMight/Mahou/releases/latest)
[![AppVeyor build](https://img.shields.io/appveyor/ci/BladeMight/Mahou.svg?style=flat-square)](https://ci.appveyor.com/project/BladeMight/mahou) [![HitCount](http://hits.dwyl.io/BladeMight/Mahou.svg)](http://hits.dwyl.io/BladeMight/Mahou) 
[![GitHub latest release downloads](https://img.shields.io/github/downloads/BladeMight/Mahou/latest/total.svg?style=flat-square)](https://github.com/BladeMight/Mahou/releases/latest)
[![GitHub downloads](https://img.shields.io/github/downloads/BladeMight/Mahou/total.svg?style=flat-square)](https://github.com/BladeMight/Mahou/releases)

# Русский [read in English](#english)

![](http://i.imgur.com/3BpvbgI.png)

# Mahou (魔法) - Волшебный переключатель раскладок.

### Как работает
Mahou работает так как **Вы** хотите, настраивайте как пожелаете, по умолчанию в отличии от других переключателей раскладок, он переключает *не по следующей раскладке*, а по **указанным в настройках** раскладкам.<br/>
Даже выделенный текст переключается между **выбранными** раскладками, но если Вам нравилось цикличное переключение, то, начиная с версии `v1.0.2.9`, есть **Циклич. режим**, в `v2.0.0.0` и выше чтобы его включить нужно выключить функцию `Переключать между раскладками`. По умолчанию Mahou - хранит настройки в папке где лежит Mahou.exe, но также может хранить настройки в %AppData%.

### Для работы необходим [.Net 4.0 или выше](https://www.microsoft.com/ru-ru/download/details.aspx?id=53345). Начиная с v1.4.3.9, исправлены ошибки при работе в .Net 4.0.

### Возможности

#### ❗️ Функция обновления из версий ранее Mahou-v2.5.7.6 не будет работать, т.к. GitHub обновился, и метод использовавшийся там для обновления больше не работает.

###### Как использовать:
1. Для конвертации выделения нажмите <kbd>Scroll</kbd>, когда выделите текст.
2. Для конвертации последнего введённого слова нажмите <kbd>Pause</kbd>.
3. Для конвертации последней линии нажмите <kbd>Shift</kbd>+<kbd>Pause</kbd>.
4. Для переключения раскладки одной клавишей нажмите <kbd>CapsLock</kbd>.
5. Начиная с v1.0.4.4, при конвертации выделения текст, не распознанный ни в одной из выбранных в настройках раскладках (пример: ♥), просто переписывается.
6. Почитайте [wiki](https://github.com/BladeMight/Mahou/wiki/%D0%A1%D0%BF%D0%B8%D1%81%D0%BE%D0%BA-%D1%84%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D0%B9) или [спросите меня](#%D0%9B%D0%B8%D1%86%D0%B5%D0%BD%D0%B7%D0%B8%D1%8F).

###### Возможности по версиям:

**v2.5.9.0**<br/>

- 📝 Обновлен RegEx по которому берется размер AS-Dict в zip.
- 📝 Изменено максимальное количество символов в уведомлении об обновлении на 640 букв, и в конце показана ссылка на архив. (исправляет #148)
- 💎🚀 Сильно улучшена функция постоянной раскладки.

  Теперь использует в 20-30 раз меньше ЦП(использует тот же метод как и в программах исключениях).
  
- 📝 Перемещены программы исключения в отдельную вкладку.
- 💎 Добавлена новая *функция-исправление-для-какой-то-программы* во вкладке тайминги.

**v2.5.8.8**<br/>

- 📝 Лучшее исправление при смены раскладки Alt+Shift/Win+Space для обновлении флагов.
- 🐛 Исправлелно что подсказки языков не обновлялись по горячим клавишам конвертаций.
- 💎 Абсолютно новые 15 флагов полностью перерисованные от BladeMight!
- 📝 Рефактор кода.
- 💎🚀 Сильно оптимизирована функция программы исключения.
  
  Из-за нее раньше очень сильно нагружался ЦП при вводе символов, т.к. в хуке каждый раз делались сильно ЦП затратные проверки, 
  теперь же все стало потреблять в 50~60 раз меньше, до оптимизации: ЦП: 6-8%  => ЦП: 0,12-0,41.

- 📝 Добавлена информация о том что обновление из Mahou версий ранее 2.5.7.6 больше не работает т.к. обновился GitHub.

**v2.5.8.0**<br/>

- 🐛 Исправлена ошибка с программами исключениями, происходящяя из-за того что некий процесс завершил работу слишком быстро.
- 🐛 Исправлена ошибка сохранения модификаторов горячей клавиши конвертации выделенного в случайный регистр(использовались модификаторы из гор. клавиши "в заглавный регистр").
- 💎 Исправлена ошибка с несколькими пробелами в Конвертациях выделенного.
- 📝 Новый способ разделения слов, новый способ получения слова по индексу буквы в линии.
- 🐛 Исправлена ошибка возникающая при переключении раскладки по Alt+Shift/Win+Space и т.д. делая так что Mahou ставил неправильный флаг. (исправляет #160)

**v2.5.7.6**<br/>

- 🐛 Исправлено что функция настройки в AppData не читалась при запуске(после добавления нового типа чтения/сохранения настроек).
- 🐛 Исправлена ошибка с проверкой обновлений.
- 🐛 Исправлена ошибка глобальной/текущей(в коде) раскладки в Mahou.
- 🐛 Исправлена утечка ресурсов иконок флагов, которое при смене раскладки увеличивало GDI обьекты в памяти.
- 🐛 Исправлено корректное обновление при включенной функции конфигурация в AppData.
- 🐛 Исправлена ошибка нового типа чтения/сохранения настроек возникавшая когда в файле настроек не было нужных значений.
- 🐛 Исправлено что функция настройки в AppData не копировала настройки в AppData при первом включении.
- 📝 Исправлено переключение на русский язык при первом запуске.
- 🐛 Добавлена ловля ошибок при проверке исключении процесса.

**v2.5.6.7**<br/>

- 📝 Исправлено отпускание модификаторов для всех горячих клавиш, теперь отпускаются только для горячих клавиш конвертаций.
- 📝 Удалены ненужные строки языков для функции Перезапуск Hook'ов.
- 💎 Добавлен новый метод сохранения/загрузки ini файлов работающий в памяти, а не обращается каждый раз к диску как прежний метод из WinAPI.
- 🐛 Исправлены разные проблемы с Языковой Панелью.
- 💎 Добавлен Эстонский флаг.
- 📝 Восстановлено позднее-исправление CapsLock(позднее потому-что через RawInput слушатели, печально: low-level хуки из Mahou не работают ни в одном окне Mahou... даже в языковой панели...).
- 🐛 Исправлено что Mahou считал количество сниппетов/слов автозамены когда те выключены.
- 🐛 Исправлены разные проблемы с доступом к еще не инициализированному(runtime) Mahou.
- 🐛 Исправлена работа перезапуска Mahou при функции Настройки в AppData включенной.
- 🐛 Исправлена загрузка(тех что в AppData) сниппетов при запуске если включена функция Настройки в AppData.
- 🐛 Исправлено что сниппеты/словарь автозамены мог быть перезаписан при запуске если включена/выключена функция.
- 💎 Добавлен более спокойный способ перезапуска/закрытия Mahou (функция PreExit, в коде).
- 🐛 Исправлено что счетчики сниппетов/слов были всегда активны.
- 🐛 Исправлено что словарь автозамены инициализировался даже если функция сниппетов была отключена(зависимость).

**v2.5.6.3**<br/>

- 🐛 Исправлена проблема с Low Level Hook'ом которая заключалась в том что сохраненное состояние клавиш модификаторов не сбрасывалось когда они отпускались(нужно для конвертаций) через Mahou, что приводило к полному отключению функции Caps-Lock как F18.
- 📝 Добавлено логирование ошибок Low-Level Hook'а.

**v2.5.6.2**<br/>

- 🐛 Исправлена ошибка нескольких Low-Level хуков, которая **сильно** снижала производительность.
- 🐛 Исправлена ошибка с обновлением Панели Языка.

**v2.5.6.0**<br/>

- 🐛 Исправлено исправление работающиее только для Windows 10, командная строка и клавиша Pause.
- 📝 Изменены позиции контроллов в интерфейсе.
- 📝 Установлен страндартный цвет текстовых форм во вкладке О.. и Обновления на цвет Окна.
- 💎 Добавлена возможность тихого обновления.
- 🐛 Исправлена ошибка бесконечного тихого обновления.
- 📝 Исправлено ненужная включенность таймера обновления иконки в трее если она скрыта.
- 💎 Добавлена возможность - постоянная раскладка только при смене окон.
- 💎 Добавлена возможность - постоянная раскладка только при смене окон единожды для каждого окна.
- 🚀💎 Оптимизирована скорость/память сниппетов/автозамены.
- 📝 Обновлен перевод.
- 💬 Добавлено 2 новые подсказки.
- 📝 Другие оптимизации памяти.
- 📝 Другие маленькие упрощения кода.
- 🐛 Исправлен серьезный баг двойного DoSelf, воспроизводимый Авто-Заменой при функции "Caps-Lock как F18" включенной.

**v2.5.5.4**<br/>

- 📝 Отключен таймер отключатель CapsLock по умолчанию.
- 📝 Добавлено исправление для поддержки функции CapsLock как F18 в функции Программы исключения.
- 📝 Изменен тип выбора для списка выбора типа для типа автозапуска.
- 📝 Добавлена очистка модификаторов при показе/скрытии окна Mahou(еще одно исправление для функции нажатия заново модификаторов...)
- 💎 Добавлена новая функция "Считать 1 Enter частью последнего слова".
- 💎 📝 Немного упрощен код.
- 📝 Журналирование теперь отображает причину очистки последнего слова/линии/текущего сниппета.(в квадратных скобках).
- 🐛 Исправлен очистка последней линии в функции "Считать 1 Enter частью последнего слова".
- 🐛 Исправлено редкое зависание модификаторов после действий горячих клавиш.
- 📝 Обновлен перевод.
- 💬 Добавлена 1 новая подсказка.
- 🐛 Исправлен серьезная проблема связанная со скоростью конвертации, появившейся после функции "Считать 1 Enter частью последнего слова".

**v2.5.5.0**<br/>

- 💎 Добавлена функция переопределения CapsLock как F18.
- 💎 Улучшена функция "Смены раскладки 1 клавишей" для поддержки CapsLock как F18.
- 📝 Добавлено исправление для Google Japanese IME в функции "Смены раскладки 1 (гор.) клавишей".
- 🐛 Исправлена двойноя работа функции "смена раскладки 1 клавишей".
- 📝 Добавлен новый класс LLHook.cs (Low-Level hook)
- 💬 Добавлена подсказка.
- 📝 Обновлен перевод.
- 🐛 Исправлена неправлильная раскладка в Mahou при смене системной горячей клавишей в некоторых случаях.
- 💎 Добавлен новый способ обновления подсказок языка - по сообщениям Windows(вместо таймеров).
- 📝 Добавлено обновление позиции подсказок языка после окончания развертывания сниппетов при обновлении по сообщениям Windows включенной.
- 🐛 Исправлено что "->" между ====> и <==== считался началом сниппетов.
- 📝 Исправлены ошибочные позиции контроллов в интерфейсе.
- 📝 Обновлен перевод в соответсвии с реальностью.
- 💎 Добвлен слушатель сообщения Windows фокуса для подсказок языка.
- 🚀 Улучшена скорость обновления вида подсказок языка при разном виде для раскладок включенном.
- 💎 Уменьшено потребление ЦПУ для подсказок языка при включенном способе обновления через сообщения Windows.
- 🚀 Улучшена скорость получения позиции подсказки для каретки.


**v2.5.2.4**<br/>

 - 💎 Добавлена возможность назначить Tab для развертывания сниппетов.
 
**v2.5.2.3**<br/>

- 🐛 Исправлено что конфигурация не читала больше 255 букв(полезно для функции смены раскладки гор. клавишами).
- 📝 Изменен тип выбора для списка выбора типа обновления.
- 🐛 Исправлена ошибка при не выбранном типе смены раскладки гор. клавишей [#140](https://github.com/BladeMight/Mahou/issues/140).

**v2.5.2.1**<br/>

- 💎 Добавлен новый метод "смены раскладки 1 клавишей".
- P.S. Оба метода смены раскладки 1 клавишей работают одновременно(вместе)!
- 🐛 Исправлены некоторые баги в смена раскладки 1 клавишей.
- 📝 Обновлен перевод.
- 💬 Добавлена 1 новая подсказка.

**v2.5.1.4**<br/>
- 🐛 Исправлено сохранение типа авто-запуска.
- 📝 Добавлена возможность скрытия флагов для функции разного вида раскладок подсказок языка. [#135](https://github.com/BladeMight/Mahou/issues/135)
- 📝 Исправлено сбрасывание позиции списков.
- 📝 Исправлена конвертация "щ" в словаре транслитерации.
- 🚀 Улучшена скорость транслитерации.
- 💎 Добавлена возможность переписи сниппетов функциями конвертации слова/линии.
- 🐛 Добавлена проверка на возможность создания/чтения настроек Mahou.ini при запуске. [#134](https://github.com/BladeMight/Mahou/issues/134)
- 💎 Улучшена функция проверки настроек при запуске, теперь Mahou будет предлагать переключиться на настройки в %AppData%, когда не может создать/прочитать Mahou.ini который находиться там где Mahou.exe. [#138](https://github.com/BladeMight/Mahou/issues/138)
- 🐛 Исправлена функция проверки настроек при запуске, теперь сохраняется после перезапуска.

**v2.5.1.0**<br/>
- 🐛 Добавлена возможность назначить 1 клавишу на Конверт последнего слова/выделения/линии(двойная гор. клавиша).
- 🐛 Заменен способ получения позиции каретки на GetGuiThreadInfo.
- 💎 Добавлена возможность включать `Эмулировать переключение раскладки` и `Переключать между раскладками` вместе, это исправляет зависания приложений вроде MSOffice2016. [подробнее на Wiki](https://github.com/BladeMight/Mahou/wiki/%D0%9F%D1%80%D0%BE%D0%B1%D0%BB%D0%B5%D0%BC%D1%8B-%D0%B2-%D0%BD%D0%B5%D0%BA%D0%BE%D1%82%D0%BE%D1%80%D1%8B%D1%85-%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B0%D1%85%3F#microsoft-office-2016skype-%D0%B8-%D0%BF%D0%BE%D1%85%D0%BE%D0%B6%D0%B8%D0%B5)
- 💬 Обновлены подсказки функций `Эмулировать переключение раскладки` и `Переключать между раскладками`.

**v2.5.0.5**<br/>
- 🐛 Исправлена пере-инициализиция сниппетов. 
- 🐛 Исправлена проблема игнорирования комментариев в сниппетах.
- 📝 Добавлена поимка ошибки "снипппет не имеет большого слова".
- 📝 Добавлено игнорирование пустых линий в сниппетах.
- 📝 Исправлена ошибка с строками в которых только 1 символов.
- 📝 Обновлен AS_dict путем поиска дубликатов обратного преобразования в словарях "!English-big.txt" и "!Russian-big.txt" с помощью dduf.sh:
[аут]<->[fen], [внук]<->[dyer], [еще]<->[tot], [зги]<->[pub], [кум]<->[rev], [нут]<->[yen], [пуд]<->[gel], [уда]<->[elf]
Удалены (некоторые просто закомментированны) те которые менее популярыне.

**v2.5.0.1**<br/>

- 💎 Добавлен счетчик закомментированных линий в счетчике сниппетов.
- 💬 Обновлена подсказка счетчика сниппетов.
- 🐛 Добавлена возможность записать в лог ошибку о том что лог занят другой программой или недоступен.
- 📝 Восстановлены Thread.Sleep()'ы. (Без них некоторые функции(работающие с буфером обмена) плохо работали в некоторых приложениях.)

**v2.5.0.0**<br/>

- 📝 Теперь в функции программы исключения исключаются сниппеты и автозамена. 
- 💎 Добавлена поддержка и функция отсылания виртуальный кодов клавиш из текстовых вводов функцией SendInput(сниппеты, автозамена, конверт выделения и т.д).
- 📝 Добавлена фикс смены раскладки в BlueStacks по Ctrl+Space.
- 📝 Теперь инициализация сниппетов идет в другом потоке, благодаря чему не замораживается пользовтельский интерфейс при инициализации.
- 💎 Добавлена функция "Конфигурация в AppData".
- 🚀 Улучшена скорость инициализации сниппетов/словаря автозамена на ~30%.
- 📝 Добавлено правило - не пере-инициализировать сниппеты если количество сниппетов не изменилось(если Вам реально нужно принудительно пере-инициализировать сниппеты/словарт автозамены тогда просто перезапуститесь).
- 🚀 Улучшен и ускорен метод подсчета/проверки на ошибки сниппетов/словаря автозамены.
- 🚀 Добавлено сохранение словаря автозамены в память(RAM), чтобы не читать с диска при пере-инициализиции.
- 🚀 Добавлен лимит отображения словаря автозамены, если словарь превышает лимит, то будет просто написано что словарь слишком большой для отображения.
- 🐛 Исправлен баг автозамены если словарь не инициализирован.
- 🚀 Еще сильнее ускорен метод подсчета/проверки на ошибки сниппетов/словаря автозамены.
- 🚀 ОЧЕНЬ БОЛЬШОЙ прирост в скорости инициализации сниппетов.
- 💎 Большое обновления словаря автозамена, теперь включает более 150000 слов(версии Mahou раньше этой(2.5.0.0) могут зависать или даже вылетать с таким словарем).
- 💎 Добавлена галочка чтобы можно было скачать словарь автозамены в zip.(AS_dict.zip)
- 💎 Добавлена проверка размера загружаемого словаря автозамены(zip или txt) при первом нажатии на кнопку обновить словарь, при втором нажатии скачивается.

**v2.4.5.0**<br/>

- 📝 Улучшено регулярное выражения взятия коммита, теперь поддерживает тэги.
- 📝 Добавлена поддержка работы в нескольких аккаунтах Windows, теперь Mahou работает во всех аккаунтах!
- 🐛 Исправления выбора функции смены раскладки после смены языка интерфейса.
- 💎 Добавлено Alt+Shift в функцию сменить язык 1 клавишей.
- 📝 Переименован snippets.txt(в репозиторие) в AS_dict.txt.
- 💎 Обновлен AS_dict.txt теперь он содержит 10000+ русских и 10000 английских слов.
- 💎 Добавлена функция Автозамены.
- 💬 Добавленя 1 подсказка.
- 💎 Добавлена кнопка: обновить словарь автозамены.
- ✨ Добавлен счетчик сниппетов/слов в функциях автозамены/сниппетов, также он показывает есть ли ошибки(когда красный).
- 📝 Обновлена вкладка О.... 
- 📝 Добавлен таймерный способ проверки правильности сниппетов.
- 💎 Автозамена и сниппеты разделены в коде, также добавлено правило ингорирования регистра в функции автозамены. 
- 🐛 Исправлен недостоющий символ ! в коде, из-за чего функция сменить язык 1 клавишей назначенной на Caps-Lock не работала.
- 📝 Другие мини улучшения кода.

**v2.4.0.8**<br/>

- 🐛 Исправлено что таймеры CapsLock/ScrollLock регистрировали горячие клавиши при вкладке гор. клавиш активной, из-за чего почти невозможно было настроить конвертацию выделения и последнего слова на 1 гор. клавишу.
- 📝 Добавлено исправление для IP адрессов в конверсии выделения.
- 💎 Улучшена функция авто-запуска, добавлено новый тип авто-запуска - создать задачу в Планировщике.
- 🐛 Убрано более не нужное исправление мистического отпускания LCtrl из PostMessage, баг более не встречается в RawInput слушателях(неубиваемая альтернатива low-level HOOK'ов).

**v2.4.0.5**<br/>

- 💎 Добавлена функция переключения на предполагаемую раскладку после конвертации сниппета.
- 🐛 Исправлено что прокси не работало если поле пароля было пустым.
- 🐛 Исправлено когда CapsLock/ScrollLock назначены как гор. клавишы вызывались таймерами.
- 🐛 Исправлено что WM_INPUT не разделял L/R модификаторы.
- 🐛 Исправлено конфликт гор. клавиш конвертации с модификаторами и функцией смены раскладки 1 клавишей.
- 🐛 Исправлено что последние слова/линия очищались если гор. клавиша с Ctrl модификатором.
- 🐛 Исправлено конфликт функции "нажимать заново модификаторы после действий гор. клавиш" с модификаторами и функцией смены раскладки 1 клавишей.

**v2.4.0.0**<br/>

- 💎❇💎❇ Low-level hook'и заменены RawInputDevices слушателями(WM_INPUT).
- 📺 Добавлена возможность конветраций в окне Mahou(но не во вкладек горячих клавиш.).
- 💎 Улучшен логгинг, теперь логгинг ведеться на отдельном потоке, благодаря чему не тормозит главный поток.
- 💬 Изменено правило "если меньше 2 раскладок" в подсказку в трее, добавлено действие при нажатии на подсказку, и убран выход из программы из-за правила.
- 📝 Логи теперь сохраняются с расширением *.txt.
- 💎 Добавлена возможность каналов обновлений.
- 💎 Добавлен канал обновлений `latest-commit`.
- 💎 Добавлена функция "Добавлять 1 пробел после сниппетов."

**v2.3.5.4~v2.3.5.6**<br/>
- 💎 Добавлена поддержка Ctrl+A(выделить всё) для многострочных текстовых форм.
- 📝 Увеличено максимальное количество отображаемых символов в сниппетах.
- 🐛 Испрально прерывание конвертации при одинаковых словах в конвертации выделения с "Считать расклдлаку для всего слова" включенной. 
- 🐛 Исправлено *съедание* линий в конвертации выделения в некоторых программах.

**v2.3.5.1~v2.3.5.2**<br/>

- 💎 Исправлена проблема конвертации выделения в обычном режиме(из-за лишней ; в коде).
- 💎 Восстановлена поддержка getconkbl.dll.  P.S. Также есть pack Mahou и getconkbl.dll в [этом](https://github.com/BladeMight/Mahou/releases/tag/v2.3.5.2) релизе на github.

**v2.3.4.4~v2.3.5.0**<br/>

- 💎 Добавлено исправление для QWERTZ клавиатур. [#107](https://github.com/BladeMight/Mahou/issues/107)
- 💎 Добавлено исправление *смерти* хука при нажатии на применить.(не подтверждено). [#102](https://github.com/BladeMight/Mahou/issues/102)
- 💎 Исправлено правило очистки слов по Alt+Tab.
- 💎 Исправлено совместимость при назначении на одну горяч. главишу конвертации выделения и последнего слова. [#104](https://github.com/BladeMight/Mahou/issues/104)
- 💎 Добавлено исправление пробелов для имен файлов в Mahou(заменяйте пробел на _).
- 🐛 Исправлена работа функции программ исключений. [#101](https://github.com/BladeMight/Mahou/issues/101)
- 🐛 Добавлено исправление в KMHook, ожидание инициализации MMain.mahou.
- 🐛 Исправлена ошибка двойных hook'ов.
- 🐛 Исправлено запоминание позиции галочки в горяч. клавишах. [#108](https://github.com/BladeMight/Mahou/issues/108)
- 💎 Исправлено включение неправлильной вкладки при проверке обновления при запуске и нажатии на ок.
- 💎 Добавлена возможность разделять имена процессов линиями.
- 💬 Добавлены новые подсказки.
- 💎 Имена процессов теперь не зависят от регистра.
- 💎 Mahou теперь имеет 2 строки с вкладками.
- 💎 Добавлена возможность включить переключение раскладки 1 клавишей даже в исключенных программах. [#109](https://github.com/BladeMight/Mahou/issues/109)

**v2.3.4.0**<br/>

- 💎 Добавлена прокрутка вкладок по колесику мыши в главном окне.
- 💎 Добавлена функция индикатора регистра ввода для языковых подсказок и языковой панели.
- 📝 Мелкие исправления в переводах.

**v2.3.3.3**<br/>

- 💎 Новая возможность - Панель языка. (она использует код из [JustUI](https://github.com/BladeMight/JustUI))
- 💎 Новая горячия клавиша - Показать/скрыть панель языка.
- 🐛 Исправлены некоторые ошибки интерфейса.

**v2.3.1.7**<br/>

- 🐛 Исправлена несовместимость прозрачного фона и функции флагов в подсказках языка.
- 🐛 Исправлено зависание позиции подсказки каретки в Firefox после прокрутки колесиком.
- 🐛 Исправлена проблема запуска Mahou без Mahou.ini.
- 🐛 Исправлена несовместимость диалогового окна удаления файлов с подсказкой каретки в Windows 10.
- 🐛 Исправлена ошибка приводящая к остановке смены флагов в трее.

**v2.3.1.4**<br/>

- 🐛 Исправлена серьезная ошибка x64 в из версии 2.3.1.3.
- 🐛 Исправлен конфилкт подсказки языка в виде флага с функцией флагов в трее.

**v2.3.0.7~v2.3.1.3**<br/>

- 💎 Добавлена новая функция - Единая раскладка для всех программ.
- 💎 Добавлена новая возможность - Всегда показывать подсказку языка возле мыши.
- 💎 Добавлена новая функция - Флаги в подсказках языка.
- 💎 Добавлено мини исправление для функции перезапуска HOOK'ов.
- 🐛 Исправлена проблема в с двойными горячими клавишами состаящих только из модификаторов.

**v2.3.0.6**<br/>

- 💎 Исправлена серьёзная ошибка функции Конвертации нескольких слов из версии 2.3.0.5.

**v2.3.0.5**<br/>
- 🐛 Исправлена серьёзная несовместимость подсказки языка лампочкой Scroll-Lock и функции Конвертации нескольких слов настроенной на Scroll-Lock.
- 🐛 Исправлено неожиданное отключение двойных горячих клавиш в 2.3.0.0.
- 🐛 Испралено невозможность запустить Mahou из-за неверных настроек шрифтов(или их отсутствия в системе) и цветов в Mahou.ini.
- 📝 Исправлены некоторые опечатки в русском языке интерфейса.
- 🐛 Исправлена очистка введенных слов при Ctrl+Любая клавиша, теперь Mahou не очищает слова если *Любая клавиша* - модификатор.

**v2.3.0.0**<br/>
- 💎 Добавлена функция перезапуска HOOK'ов.
- 💎 Переписан способ регистрации горячих клавиш.
- 💎 Добавлена поддержка AltGr для функции Переключать раскладки по клавишам.
- 💎 Обновлена функция конвертации нескольких слов для поддержки нового способа регистрации горячих
- [...](https://github.com/BladeMight/Mahou/releases/v2.3.0.0)

**v2.1.2.6**<br/>
- 💎 Добавлена функция постоянной раскладки для процессов.

**v2.1.2.0~v2.1.2.3**<br/>
- 💎 Добавлена поддержка getconkbl.dll, который позволяет получить правильную раскладку в консольных приложениях. ТОЛЬКО x86 версии обоих(Mahou и getconkbl.dll) поддерживаются. (вы можете взять dll [отсюда]( https://github.com/Elfy/getconkbl), поставьте ее в папку где находится Mahou.exe, возможно потребуется перезапуск Mahou)
- 🐛 Исправлены проблемы связанные с восстановлением буфера.
- 💎 Добавлена Shift+CapsLock к переключеать раскладки по клавишам.
- 💬 Обновлен способ показа подсказок, :rocket: теперь быстрее показывается, и таймаут исчезания - 20 сек.
- 💎 Обновлен способ локализации.

**v2.1.1.2~v2.1.1.6**<br/>
- Обновлена wiki.
- Добавлена функция **Считать раскладку для всего слова в КВ** которая **прекрасно** конвертирует выделенный текст в котором есть слова с символами.
- Добавлено правило — не переключать раскладку в функции **Переключать раскладки по клавишам** если до отпуска клавиши была надата кнопка мыши.
- Исправлено включение CapsLock'а при **выключенном таймере отключателе CapsLock** по Ctrl+CapsLock.
- Исправлено что символы и цифры с Numpad(**Я не про Alt+Numpad**) не ловились в текущее слово.

**v2.1.1.1**<br/>
- Добавлена возможность изменить текст для подсказок языка.
- Исправлено восстановление текста который был в буфере обмена перед конвертацией выделенного в некоторых приложениях(MS Office 2016 и т.д.).
- Исправлен вид для остальных раскладок при включенной функции **Использовать разный вид для раскладок**.
- Обновлено отладочная информация, теперь включает тэги &lt;details> и &lt;summary> для создания спойлеров для чтобы уменьшить занимаемое место в комментариях на GitHub. Данные прокси из Mahou.ini теперь не включаются в отладочную информацию.
- Исправлено сохранение данных прокси.
- Добавлено скрытие вида пароля прокси и шифрование пароля в файле настроек.

**v2.1.0.4**<br/>
- Добавлена поддержка [MCDS](https://github.com/BladeMight/MahouCaretDisplayServer), который добавляет возможность отображения подсказки языка возле каретки в Sublime Text 3.
- Добавлена функция прогамм-исключений.

**v2.0.0.3**<br/>
- Улучшено циклическое переключение раскладок. Теперь поддерживает приложения вроде WordPad и Skype(форма ввода сообщения).

**v2.0.0.0**<br/>
- Обновлен интерфейс.
- Сильно улучшены функции использующие таймеры.
- Добавлена очистка памяти, теперь Mahou потребляет ~5МБ ОЗУ.
- Добавлены функции конверсии регистра текста.
- Много исправлений.

**v1.5.2.0**<br/>
- Добавлено фунция отображения флагов стран в трее.

**v1.5.0.0**<br/>
- Добавлена функция отображения подсказки текущего языка рядом с позицией каретки (текстового курсора).
- Добавлена возможность выбора разных цветов/шрифтов для разных раскладок в подсказках языка.

**v1.4.4.1**<br/>
- Добавлена функция *Отладочная инф.* (Debug Info), которая копирует отладочную информацию в буфер обмена.

**v1.4.3.2**<br/>
- Добавлена функция логирования (журналирования) для поиска ошибок.

**v1.4.3.0**<br/>
- Переписана функция конверт линии для поддержки новой функции Конверт нескольких последних слов.

**v1.4.2.1**<br/>
- Добавлена возможность отключения проверки обновления при запуске (полезно для пользователей Chocolatey, т.к. там есть `cup all -y`).

**v1.4.1.7**<br/>
- Добавлена возможность подсветки Scroll Lock при активном языке 1.

**v1.4.1.6**<br/>
- Добавлена возможность ввода символов Alt+Numpad с их последующей конвертацией.

**v1.4.0.0**<br/>
- Добавлена возможность установки сниппетов (автозамена слов на другие слова/куски текста).

**v1.3.1.0**<br/>
- Добавлена возможность установки прозрачного фона для подсказки текущего языка.

**v1.3.0.0**<br/>
- Добавлена возможность двойных горячих клавиш (2x<kbd>Shift</kbd>, и т.д.).

**v1.1.5.6**<br/>
- Добавлена маленькая подсказка текущего языка при наведении мыши на текст.

**v1.1.2.0**<br/>
- Добавлен движок языков и русский язык.

**v1.1.1.0**<br/>
- Добавлена возможность `Расширенная настройка CTRL'ов`.

**v1.1.0.0**<br/>
- Добавлена возможность `Авто-Восстановления` ТЕКСТА для Конверт выделения.

**v1.0.9.6**<br/>
- Возможность `Use Alt+Shift in CM` улучшена в `Эму` (которая более настраиваемая).

**v1.0.8.7**<br/>
- Добавлена возможность `"" " ←` (Съесть один Space).

**v1.0.7.9**<br/>
- Новый, более совместимый способ сохранять/загружать настройки.

**v1.0.4.7**<br/>
- Возможность `Обновление` улучшена в `Авто-обновление` (Auto Update).

**v1.0.4.2**<br/>
- Добавлена возможность `Обновление` (Update).

**v1.0.4.0**<br/>
- Добавлена возможность `Конверт линии` (Convert Line).

**v1.0.2.9**<br/>
- Добавлена возможность `Циклич. режим` (Cycle Mode) которая переключает раскладки циклично. Применимо к `CapsSwitch`.

**v1.0.0.7**<br/>
- Добавлена возможность `CapsSwitch` - возможность переключать раскладки нажатием CapsLock.

**v1.0.0.4**<br/>
- Добавлена возможность изменять горячие клавиши для `Конверт слова` (Convert Last) & `Конверт выделения` (Convert Selection).

### Горячие клавиши
- <kbd>Pause</kbd> - Конверт последнего слова.
- <kbd>Shift</kbd>+<kbd>Pause</kbd> - Конверт линии.
- <kbd>Scroll</kbd> - Конверт выделения.
- <kbd>Shift</kbd>+<kbd>F11</kbd> - Конверт нескольких последних слов, для выбора количества нажимайте 1-9(0 = 10) на клавиатуре(не NumPad)..
- <kbd>Shift</kbd>+<kbd>F9</kbd> - Переключить видимость языковой панели.
- <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>Alt</kbd>+<kbd>Win</kbd>+<kbd>Insert</kbd> - Показать/скрыть главное окно.
- <kbd>Shift</kbd>+<kbd>Alt</kbd><kbd>PageUp</kbd> - Перезапустить Mahou.
- <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>Alt</kbd>+<kbd>Win</kbd>+<kbd>F12</kbd> - Завершить Mahou.
- Остальные гор. клавиши выключены по умолчанию или имеют описание в Mahou.

### [Скачать или посмотреть заметки о выпусках.](https://github.com/BladeMight/Mahou/releases)

### Используете Chocolatey? `cinst Mahou` для установки.

### Wiki
Ознакомьтесь с [Mahou Wiki](https://github.com/BladeMight/Mahou/wiki).

### Лицензия
Mahou находится под GPL v2+.

### Связаться со мной
Если Вы нашли ошибку или есть идея как улучшить Mahou напишите её [здесь](https://github.com/BladeMight/Mahou/issues)
или свяжитесь со мной через [email](mailto:BladeMight@gmail.com) (можете спрашивать о чем угодно)

### Поддержать проект материально

Если Вы считаете что хотите помочь материально, буду очень благодарен :)

Кошельки:

- Яндекс.Деньги: 410015057363201 или http://yasobe.ru/na/mahou
- MasterCard: 5168 7573 3941 2985

# English

![](http://i.imgur.com/3BpvbgI.png)

# Mahou (魔法) - The magic Layout Switcher.

### How it works
Mahou works like **You** want, configure it as you wish, by default it switches *not by next layout*, but by **specified in settings** layouts. <br/>
Even selected text switches just between **selected** layouts, though if you liked cycling through, starting from `v1.0.2.9` there is **Cycle Mode**, in `v2.0.0.0` and above to activate it you just need to disable function `Switch between layouts`. By default Mahou stores configurations in folder where Mahou.exe is, but there is a function that makes Mahou store them in %AppData%.

### Mahou requires [.Net 4.0 or greater](https://www.microsoft.com/en-us/download/details.aspx?id=53345) to work properly. Beginning from v1.4.3.9 error when running on .Net 4.0 were fixed.

### Features

#### ❗️ Updates from lesser than Mahou-v2.5.7.6 won't work, because GitHub has updated, and method to update used in there won't work anymore.

###### How to use:
1. To convert selection hit <kbd>Scroll</kbd> when select text.
2. To convert input hit <kbd>Pause</kbd> when typing.
3. To convert line hit <kbd>Shift</kbd>+<kbd>Pause</kbd>.
4. To change layout by one key press <kbd>CapsLock</kbd>.
5. Starting from v1.0.4.4 in Convert selection unrecognized text by all selected layout in settings (example: ♥) just rewrites.
6. Read the [wiki](https://github.com/BladeMight/Mahou/wiki/Functions-list) or [ask me](#license).

###### By version features:

**v2.5.9.0**<br/>

- 📝 Updated regex to get AS-dict in zip size.
- 📝 Changed maximum size for update messagebox to 640 characters, and add an line with link to zip. (fixes #148)
- 💎🚀 Highly optimized persistent layout function.

  Now uses 20-30x times less CPU. Uses same method as in excluded programs optimization fix.
  
- 📝 Moved excluded programs into separate tab.
- 💎 Added new *some-program-fix* option in timings tab.

**v2.5.8.8**<br/>

- 📝 Better fix for alt+shift layout switching.
- 🐛 Fixed language tooltips wasn't updating on convert last, etc. hotkeys.
- 💎 Fully 15 new flag icons, all drawn by BladeMight!
- 📝 Code refactor.
- 💎🚀 Highly optimized excluded programs functions.

  Its caused high slowdown with hooks due to too consistent check for current window's process name, now it does it only for first time, and stores the handles of windows which are excluded. Before 6-8% CPU Ater: 0,12-0,41 CPU, 40-60x times faster.

- 🐛 Fixed latest speed-up fix wasn't working properly without another list:
 
  List that stores windows handles that are not excluded, so it will faster check them throug list rather than finding process's name.

- 📝 Added note about GitHub update and not working updates from Mahou version less than 2.5.7.6 in GitHub repository's Readme.md.

**v2.5.8.0**<br/>

- 🐛 Fixed bug with excluded program crash when process exits too fast.
- 🐛 Fixed hotkey to random selection was saving wrong modifiers(from to title case hotkey).
- 💎 Fixed multiple spaces in convert selection error.
- 📝 New type to split words, new type to get word by index of char.
- 🐛 Fixed keyboard layout switch by Alt+Shift/Win+Space etc causing Mahou to mismatch the country flag. (probably fixes #160)

**v2.5.7.6**<br/>

- 🐛 Fixed AppData configs wasn't re-reading after switch, after implementing new configs type.
- 🐛 Fixed updates info title get regex.
- 📝 Switched to Array type info for updates.
- 🐛 Fixed bug with wrong global/current layout load.
- 🐛 Fixed memory leak with flag icons, causing on layout change increasing of GDI objects in memory.
- 🐛 Fixed Mahou wasn't updating correctly with AppData configs enabled.
- 🐛 Fixed update path error(With AppData configs).
- 🐛 Fixed error with configs read when they missing some values.
- 🐛 Fixed AppData configs wasn't copying default for 1-st time when enabled.
- 📝 Fixed bug with startup language switch to russian on russian systems.
- 📝 Inverted configs check/save order.
- 🐛 Added error check for case when process exits too fast.

**v2.5.6.7**<br/>

- 📝 Fixed modifiers was releasing for all hotkeys, now only for conversion hotkeys.
- 📝 Removed not used tooltip string for RestartHooks.
- 💎 Added in memory ini writer/reader(replace for WinAPI ini read/writefrom disk).
- 🐛 Fixed various language panel issues.
- 💎 Added estonian flag.
- 📝 Restored CapsLock late-fix(late because of RawInput listeners, sadly: low-level hooks from Mahou not works on any of Mahou's windows... even language panel...).
- 🐛 Fixed Mahou was counting autoswitch dictionary when autoswitch is disabled.
- 🐛 Fixed various access errors to yet not initialized Mahou.
- 🐛 Fixed restart Mahou wasn't working with Configs in AppData enabled.
- 🐛 Fixed startup Configs in AppData switch.
- 🐛 Fixed snippets/autoswitch were rewritted on on/off at startup.
- 💎 Added safer exit/restart of Mahou (PreExit function).
- 🐛 Fixed snippets/autoswitch count label was enabled always.
- 🐛 Fixed autoswitch was initializing when snippets were disabled(e.g. dependency).
- 📝 Added fix for autoswitch tab controls were updating only at tab switch.
- 📝 Moved timers closer in code(just for readability).

**v2.5.6.3**<br/>

- 🐛 Fixed Low Level Hook has stuck modifiers when they were actually released by Mahou.
- 📝 Added LLHook error log.

**v2.5.6.2**<br/>

- 🐛 Fixed Multiple Low Level Hooks a huge performance issue.
- 🐛 Fixed Cross Thread lang panel access issue.

**v2.5.6.0**<br/>

- 🐛 Fixed Windows 10 only fix for command line Pause key.
- 📝 UI reposition.
- 📝 Set default color to Window color for About & Updates info.
- 💎 Added silent update feature.
- 🐛 Fixed infinite silent update.
- 📝 Fixed tray icon update timer was enabled even if tray icon is invisible.
- 💎 Added new feature - persistent layout change only on window switching only once.
- 🚀💎 Optimized snippets/autoswitch initialization for memory.
- 📝 Other memory managment fixes.
- 📝 Updated translation.
- 💬 Added 2 new tooltips.
- 📝 Other minor code optimizations.
- 💎 Added new feature - persistent layout change only on window switching.
- 🐛 Fixed double DoSelf bug in autoswitch.

**v2.5.5.4**<br/>

- 📝 Disable CapsLock timer by default.
- 📝 Added fix for exluded program to support CapsLock As F18.
- 📝 Changed dropdown style to list style(like readonly) for startup type.
- 📝 Added clear modifiers on every Mahou show/hide (another fix for repress modifiers...)
- 💎 Added new feature Add 1 Enter to last word.
- 💎 📝 Code simplicity improvements.
- 📝 Logging about clearing words now specifies reason(in squared paranthesis).
- 🐛 Fixed "Add 1 Enter" feature wasn't clearing last line.
- 🐛 Fixed stuck modifiers on hotkey action.
- 📝 Updated translation.
- 💬 Added 1 new tooltip.
- 🐛 Fixed serious slow-bug in clear modifiers and keybd_event.

**v2.5.5.0**<br/>

- 💎 Added remap CapsLock as F18 feature.
- 💎 Improved specific layout switching keys/hotkeys to support CapsLock as F18.
- 📝 Added Google Japanese IME fix for specific layout switching keys/hotkeys.
- 🐛 Fixed specific layout switching was working multiple times.
- 📝 Added new class LLHook.cs (Low-Level hook)
- 💬 Added new tooltip.
- 📝 Updated translation.
- 🐛 Fixed Mahou's layout wasn't changing sometimes on system hotkey layout switching.
- 📝 Added language tooltips update with windows message at snippets end.
- 🐛 Fixed snippets -> between ====> and <==== was counted as snippet begin.
- 📝 Fixed excluded programs label position.
- 📝 Updated translation to match reality.
- 💎 Added focus event listener for language tooltips refresh on messages.
- 🚀 Increased speed of language tooltips refresh with different appearence for layout enabled.
- 💎 Decreased CPU usage of language tooltips refresh on messages.
- 💎 Added new type for updating language tooltips, through Windows messages.
- 🚀 Increased caret position get time.


**v2.5.2.4**<br/>

 - 💎 Added snippets custom expand key feature, and Tab key for it.

**v2.5.2.3**<br/>

- 🐛 Fixed configs wasn't reading more than 255 characters(useful for switch layout by hotkeys feature).
- 📝 Changed updates channel combobox dropdown to list style.
- 🐛 Fixed layout string was empty error for switch layout hotkeys [#140](https://github.com/BladeMight/Mahou/issues/140).

**v2.5.2.1**<br/>

- 💎 Added new specific key type.
- P.S. The specific key layout switch methods works TOGHETER!
- 🐛 Fixed some bugs in specific key sets.
- 📝 Updated translations.
- 💬 Added 1 new tooltip.

**v2.5.1.4**<br/>
- 🐛 Fixed autostart type wasn't saving.
- 📝 Added feature to disable display of certain layout when display flags feature active for language tooltips. [#135](https://github.com/BladeMight/Mahou/issues/135)
- 📝 Fixed listboxes was resetting its position after apply.
- 📝 Fixed transliteration dictionary "щ" conversion.
- 🚀 Improved transliteration speed.
- 💎 Added ability to re-write snippets by convert last/line.
- 🐛 Added error check and message box for creating/reading Mahou.ini at startup. [#134](https://github.com/BladeMight/Mahou/issues/134)
- 💎 Added force configs in %AppData%, when Mahou can't read/write Mahou.ini where Mahou.exe is. [#138](https://github.com/BladeMight/Mahou/issues/138)
- 🐛 Fixed .force file was deleting by applying configs.

**v2.5.1.0**<br/>
- 🐛 Fixed conversions for same hotkeys but double for convert line and single for convert last.
- 🐛 Got rid of thread attach/detach, using now GetGuiThreadInfo for getting caret position.
- 💎 Added emulate layout switching and switch between layouts to work together, that fixes crashing of apps like MSOffice2016. [detailed on Wiki](https://github.com/BladeMight/Mahou/wiki/Problems-in-some-programs%3F#microsoft-office-2016skype-and-similar)
- 💬 Updated switch between layouts and emulate layout switching tooltips.

**v2.5.0.5**<br/>
- 🐛 Fixed snippets wasn't re-initializing. 
- 🐛 Fixed snippets wasn't ignoring commented lines
- 📝 Added "snippet has no expansion" error catch in snippets/auto-switch.
- 📝 Added ignore empty snippets lines.
- 📝 Fixed snippets lines with only 1 / producing error.
- 📝 Updated AS_dict by finding reverse-conversion duplicates in dictionaries "!English-big.txt" and "!Russian-big.txt" with dduf.sh:
[аут]<->[fen], [внук]<->[dyer], [еще]<->[tot], [зги]<->[pub], [кум]<->[rev], [нут]<->[yen], [пуд]<->[gel], [уда]<->[elf]
Removed (some just commented) the ones that are less popular.

**v2.5.0.1**<br/>

- 💎 Added commented lines feature in snippets.
- 💬 Updated snippets/auto-swich words count tooltip.
- 🐛 Added error catch if logging file in use, etc.
- 📝 Restored Thread.Sleep()'s. (Without them some functions(that have something to do with clipboard) seems to work badly in some programs.)

**v2.5.0.0**<br/>

- 📝 Added excluded programs to exclude snippets/autoswitch. 
- 💎 Added vk-based support SendInput for snippets/etc.
- 🐛 Fixed serious KInputs bug from 9b47d26. 
- 📝 Added layout-change fix for BlueStacks.
- 💎 Added key code fix feature.
- 📝 Added init snippets on seperate thread to not block GUI.
- 📝 Changed default check time for auto-switch to 1.5s.
- 💎 Added "Configs in AppData" feature.
- 💎 Improved Configs in AppData to save snippets, logs in AppData too.
- 🚀 Speed up snippets initialization by ~30%.
- 📝 Added rule to re-initialize snippets only if snippets count changed.
- 🚀 Added simplified and faster check for count of snippets.
- 🚀 Added in-memory auto-switch dictionary, for no-need to read from disk each time.
- 🚀 Added limit for auto-switch dictionary textbox display, if it exceeds it just says that dictionary is too big to display.
- 🐛 Fixed auto-switch bug if auto-switch dictionary not ready.
- 🚀 Increased speed of counting snippets.
- 🚀 VERY HUGE performance boost in snippets load by adding my own parser, it is ~x40 times faster that using regex, and uses a lot smaller memory.
- 💎 Big update to auto-switch dictionary, now included 150000+ words(older versions of Mahou will probably freeze or hang with these).
- 📝 Added memory clear on snippets count end.
- 💎 Added checkbox to download a AS_dict.zip.
- 💎 Added check AS_dict download size on first click to update.

**v2.4.5.0**<br/>

- 📝 Updated commit get regex to accept tags.
- 📝 Added support for multiple windows accounts, now Mahou can run on multiple accounts!
- 🐛 Added fix for switch between layout when user interface language changed.
- 💎 Added Alt+Shift to conversion by 1 key feature.
- 💎 Updated AS_dict.txt now includes 10000+ russian and 10000 english words.
- 📝 Renamed snippets.txt(in repository) to AutoSwitchDictionary, AS_dict for short.
- 💎 Added Auto-Switch feature.
- 💬 Added 1 tooltip.
- 💎 Added button with which you can download latest Mahou auto-switch dictionary.
- ✨ Added words/snippets count to AutoSwitch and Snippets features tabs, it also displays if there errors in snippets(when red).
- 📝 Updated about tab. 
- 📝 Added timered re-check for right snippets.
- 💎 Separated auto-switch from snippets and added case-insensitive rule. 
- 🐛 Fixed missing ! in code, caused switch layout by 1 key as CapsLock not to work at all.
- 📝 Other mini code improvements.

**v2.4.0.8**<br/>

- 🐛 Fixed timers was re-enabling hotkeys on hotkeys tab which caused impossible to assing same hotkey for 2 convert hotkeys.
- 📝 Added fix for ip conversion in convert selection.
- 💎 Improved autostart feature to select type, added new autostart type - create task scheduler task.
- 🐛 Removed unecesarry fix for LCtrl up via post message, which reproduce no-more in RawInput listeners.

**v2.4.0.5**<br/>

- 💎 Added switch to guess layout after snippet expanded feature.
- 🐛 Fixed wrong control emptiness check for proxy.
- 🐛 Fixed CapsLock/ScrollLock when assigned as hotkeys was called by timers.
- 🐛 Fixed WM_INPUT was not distinguish L/R modifiers.
- 🐛 Fixed conflict with conversion hotkeys and change layout by 1 modifier.
- 🐛 Fixed convert last word/line was clearing with ctrl modifier.
- 🐛 Fixed conflict between repress modifiers and change layout with 1 key.

**v2.4.0.0**<br/>

- 💎❇💎❇ Replaced low-level hooks with RawInputDevices listeners(WM_INPUT).
- 📝 Removed a lot of usage of [self] and replaced it completely with DoSelf(action) function.
- 📺 Added conversion functionality in Mahou window(but not in hotkeys tab).
- 📝 Added convert selection selected text get in Mahou window fix(usuall way not worked in Mahou window).
- 💎 Improved logging, now it logs on separate thread, which makes it not to slow down main thread.
- 💬 Changed if less than 2 layouts message box to tray icon tooltip, and removed shutdown.
- 💬 Added on-click action for balloon tooltip.(open layouts configurations)
- 📝 Removed some unused variables/code.
- 📝 Save logs with *.txt extension.
- 💎 Added update channels feature.
- 💎 Added `latest-commit` update channel.
- 💎 Added "Add 1 space after snippets" feature.
- 📝 Quite overhaul.

**v2.3.5.4~v2.3.5.6**<br/>
- 💎 Added Ctrl+A support for multi-line textboxes.
- 📝 Increased Max snippets textbox display chars.
- 📝 Another inits for Ctrl+A multiline textboxes.
- 🐛 Fixed repeated words conversion termination in convert selection one layout whole word. 
- 🐛 Fixed lines eating in convert selection in some programs.

**v2.3.5.1~v2.3.5.2**<br/>

- 🐛 Fixed mistake symbol ; in default convert selection mode. (It caused it not to convert at all.)
- 💎 Restored getconkbl.dll support. P.S. There is also an pack with Mahou x86 and getconkbl.dll in [this](https://github.com/BladeMight/Mahou/releases/tag/v2.3.5.2) release on github.

**v2.3.4.4~v2.3.5.0**<br/>

- 💎 Added QWERTZ keyboard fix. [#107](https://github.com/BladeMight/Mahou/issues/107)
- 💎 Added fix for hooks die on apply(unconfirmed). [#102](https://github.com/BladeMight/Mahou/issues/102)
- 💎 Fixed Selection and Last Word conversion with same hotkey. [#104](https://github.com/BladeMight/Mahou/issues/104)
- 💎 Added space fix in process names for persistent layout process names and excluded process names (replace space with _).
- 🐛 Fixed excluded programs feature. [#101](https://github.com/BladeMight/Mahou/issues/101)
- 🐛 Added fix for bug in KMHook for non-initialized MahouUI.
- 🐛 Fixed double hooks bug.
- 💎 Restored fix for ctrl/alt/win+tab clear words.
- 🐛 Fixed hotkey enabled checkbox wasn't remembering its state for hotkeys. [#108](https://github.com/BladeMight/Mahou/issues/108)
- 💎 Fixed update on click from message box was showing not right tab.
- 💎 Added line breaks as seperators for process names.
- 💎 Make process names case insensitive in Mahou.
- 💎 Make Mahou have 2 row of tabs.
- 💬 Added new tooltips.
- 💎 Added feature to change layout by 1 key in excluded programs. [#109](https://github.com/BladeMight/Mahou/issues/109)

**v2.3.4.0**<br/>

- 💎 Added tabs switch by wheel scroll in main window.
- 💎 Added new function - input uppercase indicator for language panel and tooltips.
- 📝 Little translation fixes.

**v2.3.3.3**<br/>

- 💎 Added new feature - Language Panel. (uses some code of [JustUI](https://github.com/BladeMight/JustUI))
- 💎 Added new Hotkey to toggle Language Panel visibility.
- 🐛 Fixed bugs in UI.

**v2.3.1.7**<br/>

- 🐛 Fixed transparent color and flags together producing both text and flags.
- 🐛 Fixed caret lang display in Firefox was stuck on screen on mouse wheel.
- 🐛 Fixed error on first startup when Mahou.ini not exist.
- 🐛 Fixed delete dialog conflict with caret lang display on windows 10.
- 🐛 Fixed wrong rule in combined refresh of flags in Mouse Lang Display and tray flags while mouse tip was disabled but display mouse tooltip always was enabled.

**v2.3.1.4**<br/>

- 🐛 fixed serious x64 bug from v2.3.1.3(which has been reloaded too).
- 🐛 Fixed tray flags & tooltip flags confilct.

**v2.3.0.7~v2.3.1.3**<br/>

- 💎 Added new feature - One(global) layout.
- 💎 Added new feature - Always show mouse tooltip.
- 💬 Added new tooltips.
- 💎 Added new feature, flags in language tooltips.
🐛 Fixed double hotkey feature for only-modifiers hotkeys (from v2.3.0.5).

**v2.3.0.6**<br/>

- 💎 Fixed serious bug in Convert Multiple Words function from v2.3.0.5.

**v2.3.0.5**<br/>

- 🐛 Fixed double hotkey ability was inacessible until restart in v2.3.0.0.
- 💎 Fixed serious uncompatibility between Scroll-Tip and Convert Multiple words as Scroll hotkey.
- 🐛 Fixed Mahou wasn't start up if fonts or colors are wrongly configured in Mahou.ini.
- 💎 Fixed Mahou was clearing catched words on Ctrl+Any key(even modifier) modifiers were excluded.
- 📝 Fixed some typos in Russian UI translation. подсказки языка лампочкой Scroll-Lock и функции Конвертации нескольких слов настроенной на Scroll-Lock.

**v2.3.0.0**<br/>
- 💎 Added Restart Hooks on each Mahou hotkey action end.
- 💎 Hotkeys overhaul migrated to Windows-style(RegisterHotkey()) which is a way more stable.
- 💎 Added AltGr support for switch layout with one key.
- 💎 Updated Convert Multiple words style to new Hotkeys style.
- [...](https://github.com/BladeMight/Mahou/releases/v2.3.0.0)

**v2.1.2.6**<br/>
- 💎 Added Persistent layout function for processes.

**v2.1.2.0~v2.1.2.3**<br/>
- 💎 Added support for getconkbl.dll, which adds support for console apps right layout recognition. ONLY x86 version of both(Mahou and getconkbl.dll) are supported. (you can get dll from [here]( https://github.com/Elfy/getconkbl), put it in directory where Mahou.exe is)
- 🐛 Fixed some clipboard restore issues.
- 💎 Added Shift+CapsLock to by key switch.
- 💬 Updated tooltip appear style, 🚀 now faster (re)show, and timeout to hide to 20 sec.
- 💎 Updated translation to dictionary style.

**v2.1.1.2~v2.1.1.6**<br/>
- Updated wiki.
- Added fucntion **Use layout for whole word in CS** which **perfectly** converts selected text in which are words with symbols.
- Added rule — not switch layout in **Change to specific layout by key** if before key release was clicked mouse button.
- Fixed Ctrl+CapsLock enabling when **CapsLock disabler timer** is off.
- Fixed Numpad numbers and symbols(i'm talking not about alt+numpad) was not catched in last word/words.

**v2.1.1.1**<br/>
- Added feature to change language tooltip text.
- Fixed clipboard text restore before converting selection in some apps(MS Office 2016 etc.)..
- Fixed appearence for non-main-layouts(two in settings) when *Use different appearence for layouts* enabled.
- Updated debug info, now it includes tags &lt;details> and &lt;summary> to create spoilers which will consume less space in comments on GitHub. Proxy settings from Mahou.ini now won't be included to debug info.
- Fixed proxy settings saving.
- Added proxy password hide in view and password encryption in the settings file.

**v2.1.0.4**<br/>
- Added support for [MCDS](https://github.com/BladeMight/MahouCaretDisplayServer), which adds ability to display caret language tooltip in Sublime Text 3.
- Added excluded programs function.

**v2.0.0.3**<br/>
- Improved layout switching by cycle. Now it supports apps like WordPad and Skype(message entry form).

**v2.0.0.0**<br/>
- Updated interface.
- Greatly increased speed of functions that using timers.
- Added memory clearing, now Mahou uses ~5МБ RAM.
- Added functions to convert text case.

**v1.5.2.0**<br/>
- ِAdded feature to display country flags in tray.

**v1.5.0.0**<br/>
- Added feature to display language tooltip around caret (carriage) position.
- Added ability to select different color for different layouts in language tooltips.

**v1.4.4.1**<br/>
- Added new feature *Debug Info*, copies useful debug info for posting issues.

**v1.4.3.2**<br/>
- Added feature logging, for debugging.

**v1.4.3.0**<br/>
- Rewrited convert line feature to support new feature, Convert Multiple last words.

**v1.4.2.1**<br/>
- Added feature to disable check for update at startup (useful for Chocolatey users, choco has `cup all -y`).

**v1.4.1.7**<br/>
- Added feature to highlight Scroll Lock when language 1 is active.

**v1.4.1.6**<br/>
- Added feature to catch Alt+Numpad symbols to use them in convert last/line.

**v1.4.0.0**<br/>
- Added feature "Snippets" (expand words to other words/text fragments).

**v1.3.1.0**<br/>
- Added ability to set transparent background for language tooltip.

**v1.3.0.0**<br/>
- Added double hotkey ability (2x<kbd>Shift</kbd>, etc.).

**v1.1.5.6**<br/>
- Added small tip which displays current layout, when hovering text with mouse.

**v1.1.2.0**<br/>
- Added language engine and Russian language.

**v1.1.1.0**<br/>
- Added feature "Extended CTRLs config".

**v1.1.0.0**<br/>
- Added TEXT auto-backup feature for convert selection.

**v1.0.9.6**<br/>
- Feature "Use Alt+Shift in CM" upgraded to "Emu" (Which is more customizable).

**v1.0.8.7**<br/>
- New feature """ " ←" (Eat one space).

**v1.0.7.9**<br/>
- New method to save/load configuration which is more compatible.

**v1.0.4.7**<br/>
- Improved `Update` feature into `Auto Update`.

**v1.0.4.2**<br/>
- Added `Update` feature.

**v1.0.4.0**<br/>
- Added `Convert Line` feature.

**v1.0.2.9**<br/>
- It is possible to switch to cycle mode, that switches to next layout. This also applies to `CapsSwitch`.

**v1.0.0.7**<br/>
- Added feature `CapsSwitch` - possible to toggle layouts by CapsLock.

**v1.0.0.4**<br/>
- Added ability to change hotkeys for `Convert Last` & `Convert Selection`.

### Hotkeys
- <kbd>Pause</kbd> - Convert last input.
- <kbd>Scroll</kbd> - Convert selection.
- <kbd>Shift</kbd>+<kbd>Pause</kbd> - Convert last inputted line.
- <kbd>Scroll</kbd> - Convert selected text.
- <kbd>Shift</kbd>+<kbd>F11</kbd> - Convert multiple last words, to select quantity press 1-9(0 = 10) after hotkey on keyboard(not NumPad)..
- <kbd>Shift</kbd>+<kbd>F9</kbd> - Toggle language panel visibility.
- <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>Alt</kbd>+<kbd>Win</kbd>+<kbd>Insert</kbd> - To toggle configs windows visibility.
- <kbd>Shift</kbd>+<kbd>Alt</kbd><kbd>PageUp</kbd> - Restart Mahou.
- <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>Alt</kbd>+<kbd>Win</kbd>+<kbd>F12</kbd> - To exit Mahou.
- Other hotkeys disabled by default or have description in Mahou.

### [Download or view release notes.](https://github.com/BladeMight/Mahou/releases)

### Using Chocolatey? type `cinst Mahou` to install.

### Wiki
Check out [Mahou Wiki](https://github.com/BladeMight/Mahou/wiki).

### License
Mahou is under GPL v2+

### Contact
If you found an issue or have an idea how to improve Mahou write [here](https://github.com/BladeMight/Mahou/issues)
or contact me though [email](mailto:BladeMight@gmail.com) (You can ask anything)

### Donate

If you think that you want to help financially, I will be very grateful :)

Wallets:

- Yandex.Money: 410015057363201 or http://yasobe.ru/na/mahou
- MasterCard: 5168 7573 3941 2985
