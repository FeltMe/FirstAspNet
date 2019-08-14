﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstAspNet.Models
{
    public class BookInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220, ImagePath= "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExMWFhUXGR4bGBgYGBkfHhkbHh0gGyAYHh0eHCogGxslHR4aITEhJSkrLi4uICAzODMsNygtLisBCgoKDg0OGxAQGzImICUtLS0tLS0tLS0vLS0tLS0tLS01LS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS8tLzUtLf/AABEIARkAtAMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAEBQMGAAECBwj/xABMEAACAQIEAwUFBQQHBAgHAAABAhEDIQAEEjEFQVEGEyJhcTKBkaHwFCOxweFCUtHxBxUkM2JygjRTc7JDRIOSk6Kk0iVUY3SUwsP/xAAZAQADAQEBAAAAAAAAAAAAAAABAgMEAAX/xAAvEQACAgEDAQYGAgIDAAAAAAAAAQIRIQMSMUEEIlFxgfATYZGhscEy0ULhFGLx/9oADAMBAAIRAxEAPwDyfVN9usfzjBVFmOhQLsYgE3nZfXYe/AyMWMBYEx7/AH/VsFcKRmq0wtz3icuc/XxOJS4LxJ14ZXqEBaVSwNgDJEnwhdyYjadsD0crUYNpWQh8RnSF8izEBTbYmbHHrFfhqUskwVMtRrChTpswQVWUkBqgqRTLeITeG21dYqlCgoo99UqQaVVPvWou4ErPf92YaozEUk7xoHlMM2SHadyeCstMqbZWpq0sCCIN/CbkxBYRe8Qb8scisTJWDeI/j9fji08czlVK9alme7crUme6DIWImRTYgKYIuDO4OrcCcQ4/Tqikn2dQaSaZApAvtLMposASZ9kxc+WKKcpVgG2upXqtY+87gdf0wOpJ/iR+eG7cTQ+1l9upoe8Xy22+OX4jTO9GYBtNAx/6W2KpyXT7k3T6ixak/lJ8/W9sbDkkb7cyTf4c7YYf1jSj+5P/AKeI6f7LtON/1hT5ULbC+X87/wCy8r4Ny8PuckvEBpPMm9+V/jv0xuTNwYBvvIHU/XPDOjxKmN6MjrOXn5ZUdfnjts5TEHuCQdyfs4k7f/LdPywrlLw+4ySoVoeR52EHpafM8r+XTEyMCSBdesm9/h1H8MGf1hTERRuP/txb/wDF5GdsSJnKUn+zwAdv7PvaP+rWk4Vt+H3GSFrUTbST5b/MdT8xiSnYid5vc2E9AJnz/DDdM4titK/rREmb/wDV7ne30NVq1MA/ciCZsaBgAnplT8/MeqfEbxRTZWUI8ydiJ1Xt5+/c72+GIl1Tc7jzvfa2HP22iSfujsLEUBuLb5bfHQz1OzdxHnNEkef+zYdSaXBNxtinLoT6mREfUbbxbfHdLhtVidImLkyAonaW2E77wb4fjtEgpGh3CKGYP3jJTZgI0ldPdoCpEgzcajg7s/nXd301UpU6VCoXZqQYBSRq00gdKmWiJk7sTthJas0m6CoJ4Kv/AFRXDCmFbW3sruSIJlY3G99ox2eFVlKoUfVJMAEidpkWt52xaeKZNkSmtBhTLgMe8R2QamaARoZlD6Vqd24Ik8tjbO0PD0egxp06Bqk02LABak6lpuxULOkwbE72i2Iy7U1V9R/hI8jpVNIAke8H37ec4zHK0+YJM9NJ5bScZjZgjkFVgL+4dI25cp/H1wRka7K6lL1AylAInVNrbe1A+GBVqxP8R62EfP088E8NqaatNmJADAyTsJ3vG2/uw0lgRMunD8nUGquFNRHMuKdRQ0Ir0YplmBddTsgeNlG9id9pq1RaTVUFJjTqqrOFpuEGkmmpQqVDLMFiCZgqRqYCGrxLJUajI1PMUzTNJk0lfGadPQaLudqeqbjq+xtimGqbgSuqx3vfVtNxN/jzxkhpuUtz9r6lpSpUT5jMl2LuxZ2OosSbluvniNqxuIHqb2+HTHAYCNzvM9N4Mc/4Y1UQEWMdJ5E2id/dtjUkidsx6k+fqPSL9McNfob+U+Wwvt6450kMJj6GMYwepi/mcNQjZsJO3Pz574wqBz25+l/yx2akcgI6agZ+P44mJsI33Ox8o2/LHWwpI4pl9pt79us8uWDKVRSOpg+ILFjci3PnsMBDNGNoHoMMMog0GtVAKKQFECWcyABewsxPUK2JzXiUhJLg5DILbnqeVus+n440yvvc+l5v5bjf3befOQpl2CqYAGp3PJQLsTMRsOW4HPE2ZdASQCVX2W3J6xbz+EYR4dFE00R1cxpUFdjM2uOXw3B93njqm8iw0kXBAEAgXHyPz9RLlqhcQ177gW6XEWG/w3xooJuSTeYBgm3WOX6YW0sDU3mzKsQGYz6k7i3qTv7hiAMOcCxgg7Wn3na/mPLBLIs+1JgCLEEGJkQBq+O+2BK6C9xETyMzciRb39PfgxBI3VqaSSFBF7EgC56A7id/446ynEKtI6qblWjSPZIKkQVIZSCscjI8rTgTXtafMHy6ix9I546QHYL84N/W8/UYptVZJbr4PQuDqVpUzUVQXpB2VCgZ1Bbu2RSAKZlgSBCnUbXqQFxfL5il94AQ5Q01UuGssuJ0k/eaSCFaJanPJQ1dyGdSlU11FZgPb5FgV0lQST4gvnFhthxTz2Tcv3IrsKVNCKrkBmdar12ZwtmJBZVO58Q5zjI9NxldY8v9lnJVRVKNMgWt7xjMS5ZF0iSwjy+ftC+Mxs3ENpAKd5vB5yB8/rnjrKsqOGM2MkblfPTbYwcTVMxa43ERJ9dhv7hf8IQgnfyiRsee+8flbHXayFxV4Hfaai6GiKisrMgcahJYFUvvIl9Q02vqMS2K7UYbgifr1v5HDrtFmGcZdnLMRl1A1EzYkc788JHE8uWxPv3wNJd1WLN5OWA3uOe3n6Y3SqQp57Rvv/KeszjKleFMCLef10xeeG9mslW4g2SVsxCoWeoalP21AlVXurAExJMzODqaigrfn9ARjfBSNc9NrGwjy+oxt/MT69PWb4sua4PlFOepL3y1stqNPU6MtRVcKdQFIEGCDE/hjvjHARkadE5gM9esC3dh9K00EWMXZpI2IAg781+NHC8f6sOxlapCTtE7C/r8hjsAySDNzE9R9emLDnOz39kp52gWNJ5WorEFqT6tM6oAZCREwCJG82CymXoGhVepTqNVTSBpqqFJYmZHdkrAHKZwPip5XkPtaAWyyEhgTp0iVnxEx4rwAq6pIiTEbmcH0c1S00xUghBUISJTvTIVmA9pQgpgJ5GbTqfZ3s3l14YmcVautiPB3i6R4mWbUwSIExhUvBe7yIzledNSoFo0lOkuTPjdoJCQrEBbm1xOJrVjJeteoXGiGpxSmKRRKY8QIeVHtavCxMGQFA0qNtdS8xKtmk7bnaTtYT0i36Ys/ZnhmTzCsW72kyMC4V1I0BHYspKTMpBBnle9i+E9n8vmMrms0VzCdzrKoalM6gqahqilYm23lvgPVjBte8hUW0VBUAgdPw/Ll6jHbDadQkza8EWIkc5jfFgocApV1y4y3eCpUd6dRarg6Ciq0qyopK6WmY5dRePjOVy2XrtRYO602AqVNZUgwJKLBECTZtRMbi2D8VN0uRttIQ94Og2tvJAMH1646XJVAisabim76abBSQ7CZVbe1tYdD0w77QcA+x5ladXx06l0YELrBMcwYZTE2NiMOe2WRGRbL5aj3lZS3eIlRlOli0QngEFjG5ImfDfA+KnSj1BtKVXpulQ03VkqIYZXBEGAd/Qg7+eO6Mm+o/5oA9w5yL8tsXD+kXg1OitOuWq1a2YJLMXWJAW40oJEWG1gMUjLsJEG3nytvvbDac/iQ3I7+MqZI1OTdQR7xBm9+u1o2jDzhlN1y1SoEYU0KipEnxGoszcE6l0r0EHrdOGkDQSTF73Mi/h1DafPlhjSzFX7JWXUdLVLqLTHdxI6gk4E7dL5jcCpKq7EXHIRbyuRfGYymkCwnzBP1t0xmLYJ5F56AcySCZ25jEyE+HYkncEHpErzmN8RCSYMdfXkdvxxMASCQY5LygcvcDH0ThmTiHcXqCMsTEGgvK+526C+088K6p1bQDtcb7bHnzP0MM+OVSFy43+4WRHm1/X1wo3M2IO46+7qJnA01g6T6HZE2gG19+Q28+mLn/RGv/xAbn7p7n/Tz9Qd8U6bxuYtBi07XO+HPZvjTZOp31OnTNQghS2owp9qysALwZMnCa6ctNxXVBhiSZNxusE4nVZh4BmyzW/ZWpJ/D34s39MSTXy7AalNIxE/vTIje0YpPFc41eo9ZlVS8s2jUAWJkmGZiJ8jGChxstSSlWAqJTnutQYPTBiVVlN1t7JECBEWGJvTdwkuir7D2spl14XXCdn6pYXdnVBBu7PCgDcmb+44pVbI18vTrLWQ03mkRrsYbvYPnt+mB8/xqpUWki+BKBBpIkhUMzrgklnJvLSd+RxP2k7S1s6VaqqKRp9nUNRXUNixgDW9hG5k7Y7T0pRb8G238vAEpp+hc+LNHZ+hMe0vKReo1h+GOu14WtwbIlLqDTBjkVpuhHkQwK+uKpW7U1fsq5N6NEUV9mBVlTJIMmpJuZvbbA+S41USi1BtFWg5lqbSIYQQUIIKNPPa22JLQks/9m/R/sfevsD5bKMyu4gLSAJ9oRqIUH/FM/AHoRi9diSf6q4ief3hvb/oRF+nORinPxcmhUoLRprScqzABtZ03BLFiTyEbDpfBfCe070cu+WSnSNKqCH1GpJDLpYzrGm3QC8bE4fWhKcarqvoGLSYz/ourqmfCsbvTcL5vKtvzJVTy/HCPtuQM5mgd+9exNt7ee0YCUFW1JqVg0iJlbzYmWJEWO+GVXjDVKgq1qNOpVsS0MAxEQXQMAzWE2A6g8ztrU3rwByqLj/SnVSMjTN3Dao5geEdbSQf+6cSf0qEU6tOv+0tJkp/52Jlh00Jqaeujreg5rilR6xrVz3rEydci4FgAhGkAecDz5zdpO1VbOEGtTpSns6e8WVNysF+fMgA23GIw7PJOC6K79Qymslr/pSWcnkAP3YH/hrbHnKypIBvtNtuZjp9QMP+Ndqq2apJSqJSApiE0d4CNhf7whrAbzfocIEJGxMj+RA2jkMaOzwlDT2y+f5JzabtHZWDB67xF5ny5/XLDKiYyrENPiIuPOl9TePdhOah3vt6+422/PDfK1A2UcmwDHkLQafwxSa48zotAdJ2jaPh/EYzHVNX/ZiBbbfz8TA4zHWvkdT+YrZJ5yswPX+J2xPBgS0e8b9De4M/PEA33v0+XwxL1HlItH1G2Kskhjx5xpy9zBoLt1k8rYBpLEXt6HrzjnbY+WGHGmH9n/4KH1IJ3+PTC9HAEQN7g++9+ewxOP8AEbqTMjEEqBJvcfnt0xtGnUL7D3elvM/AYkp1DHqbWt7hsccI5JHTygeuAUx0O1UqTJJBsep5j0P1bHJBJkANvEeRNj5iPl78G5TSAajQwBIEbzE9CCZ0jpczOmC1yeSeuneFqlNFMsqMQWQA6dAJszsCqmykBjEIZRzrLGq+Cr96dUQZtEbfjbfHZg3Ivtb6+pnDfj7gijKBKhVtaKLJ4zpLzfWV3m5EE3N1lDJsVbaAJtzAIE9Ik7nfzOHUk1YlO6A2EkzytJN+o9ZF8aEX6xbnPvwRVpt+6I36A/Kff544pqbG0db8+Ynynpth7wJtyS0JIPMk7A7eYn4e73Y7MARNrenu+vwxGGkR4gB635yQfnH5Y07zvMn0n487fQwtZHtJErNtpi0nnbnzMeW18R98SJIBjnO/nzAtzxG9XbmOdgdj5i/L9ccPXJtz+V/TltgqIHMJqPHskxzgyfMSN/jbHNOpeCARtYczNyI+uW2B6dSOUHb9RfBTE0yFdblQwE3gm0xcSIMHcEHYjAao5SO+7GobbiDzsSZmd5xupSEX2tEATe4kjnzx1TgX5bgAbnfxfvftfGcD1SY0iOZPxH1OFVtjukjgCDFvUxF/I74Y5dz9lcHxeMi0j/dRM/OOWFOroNv59flywyoVD9meRJ1kdOdK/wCuGmuCaYPS2uST5QQPLGYHo1jG8esfw2xrDbRd6Bnsb+/89uWOlq9OX1v9XxyqmeWO9JAn5X/TDiIc8ZSUy/TuUj4n5YVEGwi8R68vr0w14h7OWn/cJY35t0vgCvc8o5yJA/PecSg8FWupoGN4g3289vW/lgimTqmYGoXOyyR4t52v7sRUasTf1AMfC34j44lpELMiLRJt/DljmNENpZZldwrikkw1ZtSKVBgNG7HchQCbjDPiFQVlp011LlxLPmKkSWnQarby+kQqXaNKi5JxWzQ1dI6iAZ3job+/0xHoCyAb+Yu3UThNlu7DuaLTnaOVrZnQBoSqQ5qLBclvvW03gBV1UxbxMefLK1FTTAHh7+pCUhVLLTUNpCXYqazmzOZCgE21RistSiRAjna9/wAR/LGJTgtG/S0G17zcRhfh8ZOt+BbKnDcsxAUqAzCiW5LoPjqqpaWZ5CIp/ZGo7jAPFaSLR1CnTp6zNNdRZqaKSsEg+KqzXY7IoFgWjCSwuskgep9PQD1xvXe4sPr445QafIW1QfwrLqaVZzDPIRFZtKhn1TVcgzCAGBzYjfbHHH8tTV9CXKeAtN6hG7m8LJ9lNwoEwTdb3YESCZtaOf1zxutlQOu1hAHqBefdiiXeuxM1wN+F8JQM7VXVwigqjHSHdvCJvqWkrEkkQWiAJaMF1+G0ENWIc0VWmgYx3jtq/tFSD4UXSxVARtTm7XqxHX6/SY+tt93ykC9i0kAk7zcxubY5wk3e4VSXgW2nw6hRqGo6iomWAWSbV6xNp3CoTMKNqalm3AZb2lZRmHYNLbOf3jctUNzpBPsqZIULO9xOLZpDppUT9zSBCWjvGMaqxHIuYjmFCjkZXEeEm3XyH6+frgQ03/JsLl0R3Vkg+K+/8o5evljmobc4v/I8jz+OJUVVjxHbYekXj44hLarb+v5e7FUBnNIxMX8v49cNKCzlKliPGfxpfLClSR5Dp+mG2UeMpUj9+OQ50hP4YE+nmgRIaFAQZmZvYY1jlUVt4Hz/ADt6YzC+v2KJLw+4Jo9xMR+PvxCQeZ+jywwanFtzabRy98TzPr54hlPFFzyPuw6kScaD+KMIy3/ASb73OA6tMRPrt+Hpgvi5E5c//SXbpJwOg1aVFyYEQJmYAA577eZwkeEP4oipkQfy5dDEA/kZxOaRBtfpuOg6+XPGLk6pYKFeSfCNMTfYSBMSZ+cbYNPBq4ZVakVLFtJYgL4V1k6p0xogm/zBxzkl1CkBV1gm/mN+fmbfUY5WobqVgeZjl5b/AF54LpZKrU0BaervWKpDKAxG6zqgNF4a55TOCH4FmwktQcAidRHhg9b+G3I35RNsDdFYbDy8CyCdtvL5eeMAKidzvM7YLy+RqsRCSOQBWTf2t/ZBtqIgHcjE+b4PWQIz0aiBz4TMyxMCABJ5XvMjrjt6ujtouqtI258sYtMm38PUX5YZVOE1oVjSPs6wLMYMgEqDMTa4m+Ba1BkIDoylpZZG/mLe73CcDcnwGs5B3Gm4AYjbn03x0aurkJ9b/p8IwRSyrupdFZln2osT5QD1n34kq8HrhSxo/taSRpMGJMgGQNI3gbY7dHqdnoBKRzHtW5/n8Mbq36+Q/HawGCxwbMsoqCg2lh4WtfYRM+1JiDc7XwG2Tqa9Oi7GBsbggwYNo5gkRzAthk0+orwYz6Y1RO+0+cdffjXebxt0tHX34MTsznWGr7PUXzOlepvqYWj9rbzxBleH1nNMBR96SKcuq6mnSIk8yNIMQTYY7dHxQMkNYQbDzkm8ny6T+OOGUA723iOR/XB+T4dmXQOKL6LnVESPIG82Nhe2IGyrRKgxBOxghRczEW545SXAWuoumOdvWff+uG2XYfZmufbJkT1pfUYXrluov0kfH0wZTU/Zm/zH03p88NOnXmIk0RPvtPr/AC2xmOadCeRP+kn5icZgWilNmEneBb94WB677zbynELqTHLzP4+k9cEVF0gGPdbn6dMaantqUk7ggD8rHHJiuIRxk+GgL/3K8/X9cCcOaKtPU5pqHUlxuqhgdQm1onpg/jNMaaAmYoqPXfAeVWGBI2IN9uRv5HAjW0DTsvGeV6tV6NI1KpesZNRlVXVwrSslSIFiilS3h3hgWCVK/DDorUkqU6sux11CH0zqQKzEB+7BeSLiFN7qu4/mCVpPrp6qQUOW1uBpJNOXCi4kgyulmLja2O+L8bzGYy1JG0VRUtKh1BipobVtYd4iWECSQQRBwU2kunUvxfiCGhpR+4SuusirSRBL0tIKuzM1kMaQTznSOoJqZxaVJMwaZX2gXDDxoS0GncFi402MwQCYgnAPaPilJ0GWoBa1NdKqQKk6lGlSp1A1JBIEzflsTFkOyxqVB36s9QmO6QgstpDVTIKpaIXabshGKUquePz78/2LnoQ8O4kql6eXpVMxUk6Gn2QdXiYaS8eN7MxAk+LmZF4RWID1szobSGs5qPpkIsFW0mDA9snF14ZwekhVK9enRgo32eiw8LaD7Tx4gRLXBNgdURjeR4hRSvooq2XpU9Ipk0wvfKT3bLNRS7hajLBWLtcEbzevl7F6+/0h1CuSvZbsgGb+7zVU6iGeAgPhkOCUIYEws6pG+D8n2HY6deTKjSs6q4JDEnUsq+wFwYuTsMWb7PXBWKjUqa1agJqtJKsh8ctU8VPURpWFIjYYP4TWKnx5qnVkD2YsRaBBNvh6Yzz7ROsP8/rA6iijZnsMSQDk3jWAWWskhCsl4LsSQwjT6HCXNdmBRUvOayxVCxLJqAvp0BlFOSRFhIgeWPTq7sagYZ2mq6h4TpuBcH2hBmxjcbztgTKCvSRHru5FOk7l1JKAySQ/jPeHSRB0iwNxhodp1Esv8/uwS00zzSlw/NUmJpVFraXAdUdxqcDVp0kgs+liYUPvecaTjtAZjWUq0O7HsEg+KwIMKrAaQLsTtZSTi85BstVrNSroxKR3eZ0AaqhU6/vaaimxAYKBHrJOAs52dp1gFp1KebpoKYifvaSwfECLuWjaQPCfAYIN1rxb769fePwTcH0E2aVxRplEYVKgM1KdT2n0xFNpOpnJZiST4ZsNsSUmp0a1PMvRqVdC93SpMpQ0nEzrSdKrqY+h0kb4rfEOAvTUvS1tTADVaZMPTG8VVU3AiSRcbkJhuvFUzGUeiVVKtMB6VMCrB0CNIfVL1IlgCdwtzECjhjGV19+8Cp5G2Z4Zm8+rZtVXTpKr46v3oQmGUd8FpqWkCSIgsT1DpZhXpVWatWpkUHQwUZGLMYQBQBdkILCNW83ET8V7Q5n7Miv3dOm5dXSorElVAV1JGoeFp5gwVECMB8QzPd8PemunmXXxqYKqqQhUyqhgTJU2U7lpnFSwn44+Q7opWxifSMNqEDLNz8Rub806YTmSN4iN+U3w1yb/ANmef3j/APz6Y3z4RCDyRLH7Qv5fnAN8ZjQdh+yD/mY/pI88ZiZoVe0BMYNiQev68h5jzxJSliOQMdJ93WemBnMCdoONhxtHv+tzH4/GzRmTHnGTHcXP9ytviPScDrTlgkgSQomOdp1ch58vnibiR8NDoKK+nP1IwMFYmFOqbBYvJ2A89uk4iuCyLrmeEd9UpUQ5UMut6rwy1FDKEGsEA+Fjp3BJAB/dA49xRajrlcjSgKndGaYJdRfSDUJhS0lvCpJAJkYYdq2TL5XK0XSa7UaYMuYQU1JkQbnU7AAmLEmbTnZjgBXUGIWoU1V6jAHuaW5olWEEssy3UEXCEHJGSUd79P7HlnBP2S7NMGKoVLqfvaxB00zIJoopAJDIZ1AyZkwphnXDc/TVaVHJ02dWuCWlqlILbVrgwSWIUWAAiAwGCkqM9VcpQpvSo0RJJ03iRKyfvNWpWJMixBhpBmr5ilQDCkoXXditmrECNRI2Xz+Fvayzm5vOb95/XtjJVwRNwiktbvXJqOpJKsV0arQzmIBWALSeog47zvGpPtE/5PAB/q9ubdYOEtfNs5vAA2UWA9BgR8yqoXJIUAnVvtz6nDx0brdk5yCM72hSkbmmhPkJPqTJY+7CCv27cVgkjQWA1TACndrCN78rYpvGuKNUquYW/hBkGwtIJ2nA+T4XUIDCmWBmLi8b7G+PTh2XTiu8jHLtEm+6ekZ3taVdEp1dQJuwAIE9TGG+T4uYLMFkGCykox5+0I69MeW5PLNUdhVq90osSL8jChQelo5eWO8rnFUaVrMvdsSh/eWboYPS/Pb4pLssGqQ8e0O7ke0ZTjCVEKkq6NIKvEGdxrAg/wCoSTiHIcHWkS1E1GeP7ttAMFrLFhoSbEG3rINB4HxpXrOoXTMGOXsmTHUEfCMXDK55kgGSAbXuvmp5b/M9Zxg1OzuGEaI6ikrJkrU80aer7vMCQtTf75Qw+8VCARpki4K3EjnVO0fAKgqFqaaKyXNMDUKizAqL4dGomSEi8WAYFTf0p063jgd6QFFUKupwJ8DTYNc/iIthcrd+rZfMApVoMop1yFKB/AlOP3izkSszt7J0wmnqOMsfT30GatFR4Rn6OeoNlq4Va5mqtQiEJVSNTQ2kDSAWsoIk3Ikj5zIRlqupiGRijVG8Aqim3hWCZawhVmbSBucRdq+EMpet3cNTaK6apMbCsSoAUVNyBHtBrajpP4jSTMcJWrl0Kd3VU1EkkJ3dJqRILXI0aGBMmIBNsbMKpR4b+jJW+GUOqBB/G522/LBWUeMu/wDnP40sBhgfKLdbeeGVKkBlnj948o50/lyxtlivMgsg2ofX8sZiMKeg+P6jGYFIdSZA5+HQ7fHGtEyOm95/n8cEVtjZb9JkjzGyn+eIEIm3Lb9fl1w6ZOSHeepyKIMR3Cz133kYXJltbLTWzOdIJ6tafcflg7ipgULQRRTf37TNxbAgrMhkTIgg+l5mN974jG6wWwWvLM9bNVK7B2SnU0ZdWVmBqmFXadKyoboCaYOLRxPOtkqNKhSBYVGJeuXZ1lSwemzQSqK2lJMmJgEg467D8MVGBYgDLLDQzgd64lw62Q6eRgmNBtzb8Krl6X2hQ1EFyEpjSAwGpQDaQJlyBFxcnbHmauot1Vhe1/ZZJ0b4nmBl6LAQxAGuNUO8RpGpiQg5iY5dQay9cv4mMk4J4hnRWoVHB8Mwk8xMaveb4ASQoiDYY7SjXmHk7qeyY3Nh8PljzHimfqalpFz3dOAF9Juw5sNsW7tRxaKJVGhjHL2lO8dCPzwv7GdkjnD3lSSpO97nrj0dOtKDlIz6iepNQiU/RB3B6R+t8NKFCtWKLRViUEDSIi83Ii/mTO3QDHuPD+x2VpgfdKT5gHDrK8NpIIRFHoBhX2tviP1GXZEuZfQ+e17N5skzReeZPP53OF9TL1KTSywQYggG45EY+ne6HQYov9IfZ9KtJnUQ63B2+Pljo9qlfeWDpdki13Xk8fyubanUNanpm8rfY72Jkg+RnFp4Xx2rU1MaqGSIswhjtTI/ZnkYM3ucVmmwCst1fkQAQfIzce74YE4eNNVdWoKxhtO5B/G8WxrlFS5McZOJ6/wjipEkqRtqUyPeJ2IMieo3jFj4nmQaBrhlDUwG1MWhkBmQAdOsHmQb2tNvOuAVzrNN/aU6ZE3tNweZiQeYB22xbuzedYVmp8gutR57ET0I+EY8ntOlTs3ac7RlSo2ZyyZipT0VaaFWVy33yKoWqxpAy2mWgHVZjB8WKLUyZpHM5Yu/dVKXfUQxeNKsK10Ng8IyEgTqB5HHqpqCjXoB5qrUVoqvplWCi5gC5SVJsdt7xRO3PDe7NRRY0TrSC7MaNXwmSbKAxVQAdlqHrA7Pqd7b0fH1/v8AIZxxZRgpUECOu23KBePdg6is5dpg+I/jTHyOAhBEHYXubD3Df9MH5e2Xb/Md/wDs/jj0ZfsigUOR0HuxmNU2Me1H+kH8cZgjJ+/bIsw4IBNieTWJ8wBIwLT6n6+friSnUseXvIgdbR9ecYgSZA+f8sPFUSk7dj7im1GALUV67Xt7v44k4FTFTMUuYU6ysxIQGppvYA6Qt439MBcWaFy9o+5T88F9lqLasw1rUdID02cEs67qLkFQw8pk4i13LHUndHo2ep16fDafdVGWrXeCKkNrFWRpZheVpwRoMkrAmbsuNUWp5J6RKk06JUmmpVZYRsSSDpvMzJOIONnK08xSyzq2urTFMsNc6ACoCx6mNIkHfecF8dT+zV7kwrCTcnSNIPmYx5Ft1jl2aHwysUEH9Xkxz2/1DHJ9jeJXfkDG5wV3ccPM8yPjqXHFEiMXiwQR5dnWepV0EXJiAZE9R6/hj27sTw8UaKoOQ+P0ceZtRC50sqIgAkArADHyt6+/F77PdpirrRrIFkwroZUzta8TH441dplucfDkHZobdzfPBdnMY6pDCXj3FTREhWduQAJPyxV8r2rz1QnRTooAY8bNN/hGIJqzQ10PRjhL2lo6qDgc1N/OMZwvi1R4FWmFPVWDKfzGGmcohqZHUHBtSWDqcXk+ZgdNQmLgn3G+Js5RKUkvOo6uYI5cx15jG+IZd0zFRV3V23jafPEGXpF/AOZnyFt+lhj1E7pnkNZotHCM04am7CZKqd/ZKAhgNvK1rjFw4WGGbsf2PwYfLFOyWVSjSh2GstAEXWP2hFiIG5BG87EYs/ZGqXrhmkzTsTvB0nnfc8ycYe0U1Zp07Sos3aBatTKlqHdhqJFUawxMDxABgRpOoGZkRMxvgTtBkzVo5V3d6oqKaVVgUQMKin7xhABVBrIAvcHzwTwzS9KorlgqMxOnUJ0sKoB0jVpvcDlOATUo18hmHpKARUTVqVnXUhVdWkGCQo2X/D5Y8+Fp+T/JpeUeRmhDeIEG4aOTTH4jDGnVP2ZoH7RA586eJu0FIDNV4FmfWDf9vxbco1c+oxrLgjLtz8Rkj1p3649ZztJ+RBRARQJAJDfA9fUYzEjVgLagvw357nr9csZjrkNtiKAdwZ+G3ui2MI6bctvqfLEj0fSPr9fnjAoiN+n11xoszUw/i7Wy/IGgh+ZjD3sOhY1xqZIaj7OsWmpbwqTpsJBABi5wj4yfDluX3C+XNsMOzNRVGY16BCJUBZ2UDQ8atQFz94IXntztn1Fen78SkX3j0/jlFTxKhUNegDThRSZW1tLJeRsfG0RadMyNWkjj/wDs1W4Mq3vucD9oMrWPEsrWpquhREk9SZFgSsgxadiTAGC+OU/uK3lqHwOPIT/h5GlrkR1Enh49R/zDA9I/lg6oD/Vw5eJZH+oYBWmGGk7EQfSIxVDQEdfIjM5rShVrS0iBIGnf4fUYf8I7HRWoreAsvJBMKbAsFFp9+NZLK901MTqIEExEjl77YtfBuM0yaqX1oQDAJJGwIAuQOeKTnultvBZQUYbqywirk1RrKWR41AG6kc7/ALJnrbFUzPZQNVdllARGlpIIkEGzSNuuLe2ZJuGBjcQQR6zjasDgKrwGm1kUcE4PVQyWX/ukf+XUY+WG3FcyaVJnLSFUkgL0HK+JlYg4qf8ASHxQU6Sof+kJn0H64aMeiFm+rPPOH8GfNVKzEkapuBuSZi492JK2WXJpUKhHKi+pZkHw9RaSLeXxvfAqH9kJGpdanSwtB5EEGbm09AMVD+kavoorTYzWcAHaSoM6mjzgAnf3YpHVnPVUFwTehCGk5vkpGQ4iRWViAwkjSehEdReDj1fszXV61N1GkGnt78eXdneF97VAYGF1a5/ZkQh9dRHwx6z2co6K9NLmKcW6jni/bGqoxdnTpvoM+DPpNc2EM58WqP7vnEmLcrx54G4DlVXJZqkuYp1QdTaqQYFSSy7gE7IsEAmQTe2GHCaTA1ykatTssyB7IXkCd52Bwm4XQehwvMisFUFjdm0ghyo8RUeEQQdQmJPTHl83XijWsFG7TGMw4BJhaYIOoknuUPNQS3qB6CcR0VnLvPhOo/sif+jtfHPaVR9pqCANOhQJJHgRV53sVP4mMS5Nx9nYEW1EXjYd37o/THo8Qj6CLLFRRek+ce7njeOGQyYOnyJiPiQcZi3qJ6AVRjf5csQd5f5YmqKpPUny3v154iNOdjb65YujPKxrxcHTlgSf7lPjfBPZXMacxpBINRHQaYLTp1jSp8JJZVAnniDiySmWsf7heXWRHlfAtGt3bqyk6kYOJj2lOofPliNboV5j8Oz1zjGY05OlmWq1UVlSlUVmjTvTZlC3SoZuwJAAmDF2nE6qHLVWosGpmmCjKZGkeGx53GFnZijQr06uW0pEd7QOliaaVlgsGbapeSVNi3xaZHVWygWqrB01U3BidO0/AAz5E48aeMeD+z4Ncciquf8A4eJ6qf8AzDEFIbYJz1BkyJVhcMB/5wJHkcRUrAE9Pj5DDrgpDk7zS2Q8y6j4zjvLZ2jSrVJo1BUWNTgA85geoi/nhJxfMuxgAwg1tGwg3v8A4V1MT/DFnyWRWsA7VHQndkYiT5xY4DT6cmlSVU+gyTjtKoCPEp5qykGOu0EYLyqAiQZGO6GTemIZ9Y6wJPrGN0V02Hw/LF4xlzIlujT2nejFPzvYrva4qVahZd4Jn3Ac8Xqjk3Nz4R8TggslPYS35/XLGiOk+Xgy6mvHhZPOeMUczkcq5DIEDfd6/bhm2A2kCd+hxXn7MMapdqgZmuXcTI8h1g+73Xtf9Is1EpKxkvVUBRtAuxj0tzNzfliLNAgKegBGJ6kvhVsH0k9a9/oK+H8JpUJ0zJImT0EC3x+JwfwZv7Wp/wABxxVxnBwftUibIZt1sPWenriE5OSbZzilhDHjuYo0ctVeq+kgzTAYhmqKe80iCC148PMSLb4izyMuXpDvartmGpkldLLTRFEsqmy05gtufEelj+LUmepl8qBKkmpVO48BBAJHLWQIMSPQ4qH9IOep0+9FJUVaCdzSVQylaladZUAaGUpr9Gp9dp6Ud7SXn+l9xZParKDxDOipUeobGo7OAYtqYn88F0o+yv8A5jHuNKNvywnLm09J/X5H6GGmUaco/PxH8afxO2PYkqS8zMnkDpqsbfD+WMxz9qK2/P8AQ4zB2sKlEEZffM79Z9ffiRVExMfx8/TG2SLjkBa+x544LgCw367/AIYfklVDHjrEDLgf7hfxOB6DL3q95ZNYDG48MyfOI6bYJ4usjLb/ANwvLzOF4oyRIMftBYmOcW3i95GFjW0Luy+9meIvQfuj/eZRzZnKq1AnxkKJDtcaf+KDsuLVxziTUGouKYrajq796bBUkPoKhbs/daldQZMCF8UYqHa/LGi2V4jlFbTUAZ2YsfEyLCsJhUZdS2jZha2LJ2Y4vTekKUzRqXpNU1N3VYkeGq5tqNRhCjyIs6x5mrFNLUS8/wB/38zTF/4jzjtPVQKodanS6EGQyagTfnAv5+8DCnRIke7y6nDSjnXWu2WrU6gRr0qhbVqYWkEt4LBjpuCOmrTibN5eJECYmBsw6r/Dl7xjNF1hmnTkk7KZQzPd5hBp7wMYZDzQhgwJ5WMz54a0c59jKqjMcu3Jx408mizJ0Yehg7ldk+HrVrVKjCQFKj/VuPcMWDN8HpVEWnUQNpFj/iHP343UmkiUpP4jZLlOM03UEOCPXHeTrhqhcGVAhQLmeZ/L44Rp2Wo6hppJYTeY+E4c5LL6X0W08okCw2scCLkpAm040MzmWPhFv8K/meXyxHU8IluWwG36nHdJuS6QBvHI9PXA/EK6ohZjYD4/Rxf5sz/JFL4lmWzGc8Xs0hpVf8T7k9TpHzwy4hS8JjoYwHw5i1UsQJux9Tb5T8sMc2x0kASSCBjFqPczfBbEkIKTawAJJ2jnMx88OAn2ei9UFNYsuoEh6nJYBBIW+3OTaDgjI8OWS3SQW/FFJ58ifd6x0c0a7VDpKZemYDsYplEKlwyzF1mGM7coIMJSvHQWdN4A8jxQ08qMwKYy8DStMg6H1KO6h4nQPbZgCd72x53x6qatV6TSUy1Oo9SXLDv3EadR3+9KIBAuHixtY+2HaTTDprRlmnl0OpSBsarKbOsaWWeYUcnGFFPgiUOEvWrK4rVyFXxNddQdNSkxc09UgTp5ycbNCKh32st0vfyXUy6j3YXQpjU/r+f5fhhjRUjKP/nPPa9K2Akn095264aJ/srSB7Ux76Xxxvm+PMikKgPOPccZjoAjmR6YzDgI3qHXPP344Jk/Lz2G/wDHEz5bmJEA/RjEWs+hAtbYcvh6Y5V0Od9RlxxTpy//AAFHPz5/xwty9Q6gGYgEiTvpBI5TyF/P34Z8XqQmX3/uF39/l+OFruSDcn03+vLbCw/ic+T0esqnuMrUrNRpGklMVNYXvDTbRp0TB16yIkqsKZMEYr1alU4fXalVQNSqSSkq8gCBVWbB1k+0ADcG1xN2gySCkGZxDH7kMKg7vSStQBShdiSNJm0qItpAKzHGtWWoCqRmFFPS7Eago7wBKgFRZDhBURiAQTpBM4xxTSxlPn37zwXeS4cE4pSqqlOu3eJANLMG+pV8CrWYqBrlmsepDXu0mWzOZoxTzKmqpOkhVAFNwggU3OnwkEEb/tiRpM+dsKvDqpUutVCS0XIYAAK9wTTbkDv5Eb23s52jGlEQmtTSPDUYd7RhSTV1MYYTYQNNxdJ04z6mjS3Ryn79PfkOpdHyXbKVe7JKrrBMkgeP1Kj2vVefIRg+hm6dT2WBnlzkfnin8N4WtWstfK5hV9llQoQ6qy+IaW2BOkzFxInY4lqZ7M1MxUp1MvRTutALqzN3mtpEMulkimr+EzLFeW6Q1JRwna+eKDKKeS3tTi4+oxpKlo5gkD4/wxXl4kiv3ZrNTYuyBahpsAApfXAYEIQD7V+oGD8lmTUPgzFOpaTpWLfEwfLfFP8AkxWWgbGNFECMV3tLV1laYk84HMjb3c8F1c5DaGzVJGnTBW8xPNhbz2m2+FtPPLWUmkzVJpF5LKqowMBXVD3q7Em8ADecdPtKku6gwhtlbNZLL6CZNz7IAliBuYF998GuAq6nBgfsIQWIkAy0wI3hTNhebELhmbzL1auXSlTpqoDGuDDEOsoRT8RLWYamJ26iML8rSo5SoRUrJVqFlUJSU+Co+rUXaSELyBeDvAJbGeVyw/oveCjleQunVrVStSqVpZcLqdGCqlOmNUMDBliYg6ogEgC2FPaTjiaNIDJRRgFpkQ2YdNIAYMpmkVjxfs2J8WlQs7QdqI0BxDIAyZdCdNIwylKpBh/IDxcvu98VzL0XqrUzdeond0h7JAudkorTI0otxeIiSJM40aeh/lLHv3n/ANJSn0J+C8Mq5x2zFdxSoUw33imO70qdKom8JA8NpA3JMlrxSp32Tq63YqlbVTqlxU7zu17pb2Hj3J3DE2iIC43xJqmVSkKi0UNRmakQYVQFNNQqAqFVSGa86mBI2xHnMsv2IujSh0imq620ldBqEMFESWYnXHtCIMjGjLabxnHv2qJrBXlvaR+Hv/XB6AHKvv7Z/GnhUrDkPn+m+G2VWMq9iZY++9PljRPFeYqd4F/0bfpjMbpvFoHv/SbYzHDIFLiIJ35x/Hb9TjVOgx8IgyN7b+fSI59D5xE4+F432vibJljUQKwBLAXmL2v5bg+/FOFgjecjvtd3Z+zdzTamq0VRtR1SwUPMztDgDa4a1sJ+HUS9WmqlVZnUAtsCSLnynFqz3Z7NVqr93lmCUlBhiuqGVWUAFrnQoEDmCd2vWgyBkcgMgYErycAyfcRb0xHSmnHan+x5QzZeuK1ClamKwZKFJkphqWlgQkaru1kLFVcnlotc4N7R8do5hEy+SQMBPiQEAPqYIiRHj1/eXFllrQYpNftArExQVAzszFGbUA3+7J9iN4uGkzvh1wXtotAstJagViSXqMXKjSAvdpqCjxmTMkrzmIzS0JJJ1lfQopp4C+IVqj5fuXWqNCqtZUqgVFPiADFhFYeE6lPkwgThPmez/gp1aPfJULHRcaWZCQSkkMgYg6SSZ28M2GyPFqMKtUPUD1NeYLgEsqrC01Orkb6pG/OILZu09EKCErnwQQ7KVBuJgCWAkwSbSSROH2zhiK9+/sd3ZckNDiOYplmrZdq603UtWpqR4gIDGooKuoUnxc7eLbDPh/ahWFNu+p1mpp4Bm0CvrJ0lu8nSAUt7ZNhbFa4XxhaZ9lwGnUFIJedXiLyGYgN7Lc1U6hedZitlCQyUKkgjWGqeE2AJUjxAne83J6YMtJN019Pf4ApfM9IyfE6Z0g5RqiLUqFHSq1QHUhLPJkKhBKhS0TEcjhjwzj2VBBXLVaZZVa6UwRPhAgOYPUDbnvjyJ/s0hl74MR7PgADTsrROgDaRM+/G6vE2AApVsyoi4NU7+QEeXXEJdkUvb/sotSj1epx3KmoNOUqs+tV1BKcAxrBnXZeRYC5teIwrzHGRTVCmWWj3dNu6+0V2USzGUam2kMd2Blrbb487XiBdSKr5hmn/AHnhKx0PPe95tjoVMqo1CnUckmA2lQFIsSV8TMDyEAifLBXZUvf+zt9ljzXaVEHd06hKK50UctT0IyFT92xIEnWSZXWPLC6omdf7tKRy4FNRDSjOgMBWdhraBqlV07nwm+B8hnMpTCsKVXvAdROu1v2QoIJDAxLTsLG4OJxpe+SsUJYbz7RFrGDLwVmSYMmy4soV/FfUnfiSVOB0ko03AzB1ywqCAW0+LSgmVcqZAYtzsCRhzxKrXq0hRCVHdYeoqVdTrTAiXqCBVJUkHqWt7OAv6+yzrpqU8wVYnwF0KxBVYPhJ02gE7WnqFkO0Hd18vW1PTamNNbQoiooLRALAairFIIhdx0wu2cstZQcItadqsoco9LM/d1VD6SoEtbw1aJckHUsESdwRbwyrytGtUytSmyiApqq9WFJgMrgAMQHKxIuNTVNzOFme7SpmD3lVKq1QgBFOqwpyCTIBJKTMEg9TE3wInGEgh8vT1NTqJILAAsQdQXYMpAk7nc4C0Wlhdb8fodusV1KY2Eef4csWHIpS+xVqZUmqWVqbBgAq61U7/vFSIjkdsJcrl2d1RBJYwoiSx5Acpviz0+D1qRq0noQUpq+oMCBqYlLqYYGqp9Jebb01ZJUr+Y0I9SpU6JImG91/K5PPGYICiAbXANr7/XnjMPuZ21CivzJjyj8+eOsjX01EcgtDAm+4m4k2mJ364mrUQE1CDJtvtfYfW+OOFx39HWsjvF1AgQRIkEHkRvi9pxZmapl2yARlpqz1q1ZWV6aKPaqU0im8swZCaIB0MPaUkGLFZx3hFGjTqOHd3apppkrCrAmoDHtMD4Og1cyrabQez2Xp06ubWqw1ilViqHTRqpOgJYKzMzPUZvCu40xucC1H76kX+4vVpoNfd9yzBGJqOWQQxAYQwDAkQRq8Xnx1O9ceOvT0NGzGTztuv0Mcg3P8rYsvG6FP7RXGXKmgH8LFgFFtgzEA3mJOw9cKG4dmWuKNQieSEg+e0H1+GNsdRNXwRlBoEU7D6BxskxJMcrz6/HBS5DMC3cVvXu6g+FrbY0vDq5F6Fe3LuqnvFl+t8NuQKBp2kTf0/lbn54YZagzSEQsQJIVSYEgT5XIE+YwMOE1v9xWt1pVOv+W+HfZrjbZOq1VVDMaZRQdgdaNJBH+GOt5kRho0xZNoFHCcwW0dxW1fu928+0U2ifblfW29safhFcOKbUKwcnSENN9RaA2kKRM6SrQORB54fZLtYtFVSnSfQtepWAZxaZ7ulOme7Vjrabs17Y5Paemct3DUNRCKqlihAK0KNDXdCwYGjqGkj2oMxh9q8Ce5+Ikr8FzCnS+WrKxmzUnBOkAtAImwIJ6SDjnMcKroX7yjWUqAX1I40qTpUtIsCbAnc2w7XtXp+0lEYfaMz3x8QhF1a2VfDOt7KzTBCi2CW7balrI9BSlZqgYDw6abByirpgalqVKlQswMk7DcdtR25+JUjTJvBPu/DGFSLbeX1vgmrmVDfdhgl4DEFovuwAE35DENerqPTE1u3U44Ns46C0t0dR7sYr65+X69SJo3g+4fA+frfEUGxgGfWR7vlfqMEf1XX/3FUz1pvHrtb+WJE4XWi1GrtY929x0Ph/icTtLqLlgTIRtPSOvQfP8ADE0Xgg+pidtvdv8ApbBb5OqBek4HVgVHlJcBdp3/ADww7M0U7x0rGmG7omh3pXujUMBZMlSLtF4tGFlOlYVFWHcL4PTmlWpd4Ham0IFHiqgFagQmLABmubSlyNWnvOV6VNF7lqoSmLoxA0qtRnCeFiWBrkjW0QKZESRqKzOcWktIsyaalNfGxELpaoGVClJm0NMyqhdJvGshmvEOz9CkprliQKa0+7UHSO8cDVrsDKMREAmZ3gDG5573oUrwPN6QMbx7x+cYzHBqHlqvvpXc/A3xrG2mJuRquA1iQRvbnvAjoJ/TGZQaXRoNmBb0BFh8MQZb8hjl9/j+LYeuhJvqXLhvax+6NGqTUp933YVlpNYezLFBcSIJVgN4OFmX4qFO2gAiAgDCAZFKorQKizeSQZZjzGkGns3+j8BiCt7beuILTjbpFW2khtme0WtmYUxSBYvKoreZUKfAoYRcSbXLcguI8er1lpK/daKSaEilTgDpdSOUWjbbnganuvq/44hq/kP+bFIwinwTldcnBzbdEj/g0eVv3PMY7XMt/g8/uqPx9jpgfMe38PwOJU/Y9MVpeBNckozzdEN7Duqfw9nriQZ153piN/uqP/t38sQUNvryxE/7P+YYFIboNBmW0z4duVGn6yfB/DbHIzzG4VPP7ul5dVt9bYgo8/XHR/ZwlFKwSLm3nZP/AA6Mf8uMbOuOSe+lS/8AbgJdl/y/mMEN7PxwWhVwTDOvzVAN/wC7p+VvY3+GOTmnn9gf9lT+fg+r+mNN7A9Dgav7a/XMYCphkqQcM0wMQkHpTpW57aZnGjmWFx3YAv8A3dL3n2PoYgGy+v8ADGVvaP8Am/M4FIaxlle0VZaRoBlFNn7yBRSS0QCJXTbwm97C4vgjLdoghOqkplGUOUU+1u/dE6Q0nkRPPVhEPY+P/wC2Mp/lgPTjnAE2OBxJTUGpS6gy2sqWYi6m4KqiiVWndYJ31SGPEu2L1SUdmFEsCUCU09lQAsQSQImNW8X5YqtH2V9PzwaNm/yjCy043lDJtoDquJgwItZR/DGYjbYeh/5jjMWSRJtn/9k=" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180, ImagePath = "https://img1.labirint.ru/books/74807/big.jpg" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150, ImagePath = "https://audioknigi.club/uploads/media/topic/2019/03/22/09/preview/85709e30dd933ee43112_400x.jpg" });

            base.Seed(db);
        }
    }
}